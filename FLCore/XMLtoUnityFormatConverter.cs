/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2025 15:25:18
 * Version: 1.0.1
 */

using System.Xml;
using System.Text;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace FLCore
{
    public class XMLtoUnityFormatConverter
    {
        public string existTags = string.Empty;
        private bool _isAlign = false;
        private bool _isUnderline = false;
        private string _logOPath = "Log_Ok.txt";
        private string _logNPath = "Log_Noup.txt";

        public XMLtoUnityFormatConverter() { }

        public XMLtoUnityFormatConverter(string text)
        {
            existTags = text;
        }

        /// <summary>
        /// TRA:
        ///     data - декорация текста - 5 - подчёркнутый
        ///     mask - ?
        ///     def - ?
        /// PARA, PUSH - перенос строки
        /// JUST - позиционирование
        ///     loc - left, right, center
        /// TEXT - текст
        /// </summary>
        /// <param name="data"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public List<string> ReadXmlData(string data, string file = null)
        {
            var unityTagsBuilder = new StringBuilder();
            unityTagsBuilder.Append(existTags);

            if (string.IsNullOrEmpty(data) || data == "  ") return new List<string>() { string.Empty, unityTagsBuilder.ToString() };
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.LoadXml(data);
            } 
            catch (Exception ex)
            {
                var error = ex.Message;
                bool isFixes = false;
                if (error.Contains("Недопустимые данные на корневом уровне."))
                {
                    if (data.Length > 5)
                    {
                        data = data.Trim();
                        isFixes = true;
                        using (StreamWriter sw = File.AppendText(_logOPath))
                        {
                            sw.WriteLine($"[{file}][{isFixes}] {error} \n");
                        }
                        return new List<string>() { data, unityTagsBuilder.ToString() };
                    }
                }
                else
                {
                    //Знак \".\", шестнадцатеричное значение 0x00, не может стоять в начале имени. Строка 1, позиция 2.
                    if (error.Contains("шестнадцатеричное значение 0x00, не может стоять в начале имени."))
                    {
                        data = data.Trim();
                        xDoc.LoadXml(data);
                        isFixes = true;
                        using (StreamWriter sw = File.AppendText(_logOPath))
                        {
                            sw.WriteLine($"[{file}][{isFixes}] {error} \n");
                        }
                    }
                    //".", шестнадцатеричное значение 0x00, является недопустимым знаком. Строка 1, позиция x.
                    if(error.Contains("шестнадцатеричное значение 0x00, является недопустимым знаком."))
                    {
                        var pos = data.IndexOf("</RDL>");
                        data = data.Substring(0, pos + 6);
                        xDoc.LoadXml(data);
                        isFixes = true;
                        using (StreamWriter sw = File.AppendText(_logOPath))
                        {
                            sw.WriteLine($"[{file}][{isFixes}] {error} \n");
                        }
                    }
                }

                if(isFixes == false)
                {
                    using (StreamWriter sw = File.AppendText(_logNPath))
                    {
                        sw.WriteLine($"[{file}][{isFixes}] {error} \n");
                    }
                }
            }
            XmlElement xRoot = xDoc.DocumentElement;    // получим корневой элемент
            string unityStr = string.Empty;
            var unityTxtBuilder = new StringBuilder();

            if (xRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xnode in xRoot)
                {
                    if(!unityTagsBuilder.ToString().Contains(xnode.Name))
                        unityTagsBuilder.Append(xnode.Name + " ");
                    switch (xnode.Name)
                    {
                        case "TRA":
                            XmlNode attrTRA = xnode.Attributes.GetNamedItem("data");
                            if (int.TryParse(attrTRA.Value, out int val) == true && int.Parse(attrTRA.Value) == 5) _isUnderline = true;
                            else _isUnderline = false;
                            continue;
                        case "PUSH":
                        case "PARA":
                            unityTxtBuilder.Append("<br>");
                            continue;
                        case "JUST":
                            _isAlign = true;
                            XmlNode attr = xnode.Attributes.GetNamedItem("loc");
                            unityTxtBuilder.Append($"<align={attr.Value}>");
                            continue;
                        case "TEXT":
                            if(_isUnderline) unityTxtBuilder.Append("<u>");
                            var text = xnode.InnerText.ReplaceNegativeSymphols("\"");
                            unityTxtBuilder.Append(text);
                            if (_isUnderline) unityTxtBuilder.Append("</u>");
                            if (_isAlign)
                            {
                                unityTxtBuilder.Append("</align><br>");
                                _isAlign = false;
                            }
                            _isUnderline = false;
                            continue;
                    }


                   
                }
                unityStr = unityTxtBuilder.ToString();
            }

            return new List<string>() { unityStr, unityTagsBuilder.ToString() };
        }
    }
}
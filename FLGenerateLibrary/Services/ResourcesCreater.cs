/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:08:13
 * Version: 1.0.3
 */

using Core;
using System.Collections.Generic;
using System;
using System.IO;
using FLCore;
using UnityEngine;

namespace Services
{
    public class ResourcesCreater
    {
        /// <summary>
        /// Адрес до файла Resx (Resources C#)
        /// </summary>
        private string _pathResources;
        /// <summary>
        /// Адрес до файла TXT взятого из файла .rc для переработки в Resx ресурс
        /// </summary>
        private string _pathStringTableTxt;
        /// <summary>
        /// Адрес до папки с файлами TXT взятых из .rc для переработки в Resx ресурс
        /// </summary>
        private string _pathDirHTML;
        /// <summary>
        /// Логи успешной обработки ошибок
        /// </summary>
        private string _logOPath = "Log_Ok.txt";
        /// <summary>
        /// Логи не успешной обработки ошибок
        /// </summary>
        private string _logNPath = "Log_Noup.txt";

        public ResourcesCreater(string path)
        {
            _pathResources = path;
        }

        /// <summary>
        /// Создаёт таблицу String Table из txt (взятого с .rc) в .resx
        /// </summary>
        /// <param name="path">Адрес до файла TXT взятого из файла .rc для переработки в Resx ресурс</param>
        /// <returns>this</returns>
        public ResourcesCreater CreateStringTableData(string path, bool extra = false)
        {
            _pathStringTableTxt = path;
            if (extra == false) GenerateStringTableEquipresources();
            else ExtraGenerateStringTableEquipresources();
            return this;
        }

        /// <summary>
        /// Дополняет в таблицу данные HTML из txt (взятого с папки с .rc) в .resx
        /// </summary>
        /// <param name="dir">Адрес до папки с файлами TXT взятых из .rc для переработки в Resx ресурс</param>
        /// <returns>this</returns>
        public ResourcesCreater CreateHTMLData(string dir)
        {
            _pathDirHTML = dir;
            GenerateHTMLIdsEquipResources();
            return this;
        }

        /// <summary>
        /// Дополняет в таблицу данные HTML из txt (взятого с папки с .rc) в .resx
        /// </summary>
        /// <param name="dir">Адрес до папки с файлами TXT взятых из .rc для переработки в Resx ресурс</param>
        /// <returns>this</returns>
        public ResourcesCreater ClearAllData()
        {
            ClearAllDataResource();
            return this;
        }

        private void ExtraGenerateStringTableEquipresources()
        {
            Console.WriteLine("Extra start process");
            if (!File.Exists(_pathStringTableTxt))
            {
                Console.WriteLine($"Файл: {_pathStringTableTxt} - не существует!");
                return;
            }

            var lines = File.ReadAllLines(_pathStringTableTxt);
            var res = new Resourcers(_pathResources);
            var c = 0;
            var count = 0;
            var dataStr = string.Empty;
            var keyStr = string.Empty;
            foreach (var line in lines)
            {
                //Console.WriteLine(c);
                //if (c >= 10) break;
                if (string.IsNullOrEmpty(line) || line.IndexOf(" ") == -1)
                {
                    continue;
                }
                else
                {
                    //read key val
                    var key = line.Substring(0, line.IndexOf(" "));
                    bool parseKey = int.TryParse(key, out count);
                    if(parseKey == false)
                    {
                        dataStr += "<br>" + line;
                        continue;
                    }
                    else
                    {
                        bool p2 = int.TryParse(keyStr, out count);
                        if (p2 == true)
                        {
                            c++;
                            dataStr = dataStr.ReplaceNegativeSymphols("\"");
                            res.AddResource(keyStr, dataStr.Trim());
                            Console.WriteLine("[parseKey]" + keyStr + "|" + dataStr.Trim());
                        }
                        keyStr = key;
                        dataStr = (line.Substring(line.IndexOf(" ") + 1)).Trim();
                    }
                }
            }
            res.AddResource(keyStr, dataStr.Trim());

            res.Generate();

            Console.WriteLine("");
            Console.WriteLine($"-> Complete! names: {c}");
        }

        private void GenerateStringTableEquipresources()
        {
            var _isParse = false;
            if (!File.Exists(_pathStringTableTxt))
            {
                Console.WriteLine($"Файл: {_pathStringTableTxt} - не существует!");
                return;
            }
            var lines = File.ReadAllLines(_pathStringTableTxt);
            var res = new Resourcers(_pathResources);
            var count = 0;
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;
                if (line.Contains("}")) _isParse = false;
                if (_isParse)
                {
                    count++;
                    ParseSring(line.Trim(), res);
                }
                if (line.Contains("{"))
                    _isParse = true;
            }
            res.Generate();

            Console.WriteLine("");
            Console.WriteLine($"-> Complete! names: {count}");
        }

        private void GenerateLog()
        {
            if (File.Exists(_logOPath))
                File.Create(_logOPath).Close();
            if (File.Exists(_logNPath))
                File.Create(_logNPath).Close();
            File.WriteAllText(_logOPath, "");
            File.WriteAllText(_logNPath, "");
        }

        private void GenerateHTMLIdsEquipResources()
        {
            if (!Directory.Exists(_pathDirHTML))
            {
                Console.WriteLine($"Папка: {_pathDirHTML} - не существует!");
                return;
            }

            string[] files = Directory.GetFiles(_pathDirHTML);
            Dictionary<int, string> textFiles = new Dictionary<int, string>();
            var res = new Resourcers(_pathResources);
            GenerateLog();
            foreach (var file in files)
            {
                if (file == "SBM\\HTML\\Log_Noup.txt" || file == "SBM\\HTML\\Log_Ok.txt") continue;

                var name = file.Substring(file.LastIndexOf("L") + 1, file.IndexOf("_") - file.LastIndexOf("L") - 1);
                var nameId = int.Parse(name);
                if (!textFiles.ContainsKey(nameId))
                {
                    var text = new XMLtoUnityFormatConverter().ReadXmlData(File.ReadAllText(file, encoding: System.Text.Encoding.GetEncoding("UTF-16")), file);
                    res.AddResource(nameId.ToString(), text[0]);
                    textFiles.Add(nameId, File.ReadAllText(file));
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"-> Complete! HTML: {files.Length}");
            res.Generate();
        }

        private void ClearAllDataResource()
        {
            var res = new Resourcers(_pathResources);
            res.RemoveAllResources();
        }

        private void ParseSring(string value, Resourcers resourcers)
        {
            var key = value.Substring(0, value.IndexOf(","));
            var val = (value.Substring(value.IndexOf(",") + 1)).Trim();
            val = val.ReplaceNegativeSymphols("\\\"");
            val = val.Replace("\"", "");
            if(val.Contains("\\n"))
                val = val.Replace("\\n", "<br>");
            resourcers.AddResource(key, val.Trim());
        }
    }
}

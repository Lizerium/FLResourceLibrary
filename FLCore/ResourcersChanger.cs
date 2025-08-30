/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:35:07
 * Version: 1.0.5
 */

using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.IO;
using System;
using System.Reflection;
using System.Linq;

namespace Core
{
    public class Resourcers
    {
        ResXResourceWriter _Writer = null;
        ResXResourceReader _Reader = null;

        Dictionary<string, string> _Values = null;

        public Resourcers(string fileName)
        {
            _Reader = new ResXResourceReader(fileName);
            _Writer = new ResXResourceWriter(fileName);

            _Values = new Dictionary<string, string>();

            if (File.Exists(fileName))
                this.LoadResources();
        }

        private void LoadResources()
        {
            foreach (DictionaryEntry entry in _Reader)
                _Values.Add(entry.Key.ToString(), entry.Value.ToString());
        }

        public void AddResource(string key, string value)
        {
            if (_Values.ContainsKey(key))
            {

                _Values[key] = value;
            }
            else
                _Values.Add(key, value);
        }

        public void RemoveAllResources()
        {
            _Writer.Generate();
            _Writer.Close();
            _Reader.Close();

            Console.WriteLine($"[Clear] Count: {_Values.Count}");
        }

        public void Generate()
        {
            foreach (string key in _Values.Keys)
                _Writer.AddResource(key, _Values[key]);

            _Writer.Generate();
            _Writer.Close();

            _Reader.Close();
        }
    }
}
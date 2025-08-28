/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:08:13
 * Version: 1.0.3
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using FLCore;
using FLData;
using FLGenerateLibrary;
using Services;

[assembly: NeutralResourcesLanguage("ru")]

public enum TypeSearch
{
    Id,
    Value
}

public class Program
{
    private static bool _initialized = true;  

    static void Main(string[] args)
    {
        Console.WriteLine("* По умолчанию файл ресурсов читается из папки проекта Properties");
        Console.WriteLine("[g] - поиск уникальных значений поля в INI файле (Example: g example.ini progres_field)");
        Console.WriteLine("[clear]/[c] - очистка файла ресурсов");
        Console.WriteLine("[st] - генерация из папки с TXT (.dll Win32 -> Resource Hacker -> .rc файл -> .txt файлы) строк в .resx файл");
        Console.WriteLine("[html] - генерация из папки HTML (.dll Win32 -> Resource Hacker -> .rc файл -> .txt файлы информационных карт) строк в .resx файл");
        Console.WriteLine("[import][i] - импорт в папку INPUT тестовых данных для генерации .resx в папку OUTPUT");
        Console.WriteLine("[all][a] - генерация сразу всех компонентов");
        Console.WriteLine("[rhtml] - вывод текста сгенерированного в папке HTML после обработки в формате для Unity - TextMeshPro");
        Console.WriteLine("[exit][e][q] - завершение работы");
        Console.WriteLine("::[text] - поиск по тексту совпадения в ресурсах");
        Console.WriteLine("!![id] - поиск по идентификатору совпадения в ресурсах");
        Console.WriteLine("-----------------------------------------------------");
        while (_initialized)
        {
            Console.WriteLine("Please Enter Command separated by space:   [clear]/[c] or [string table]/[st] or [html]/[h] or [exit][e][q]");
            var command = Console.ReadLine();
            ApplyCommand(command);
        }
        Console.ReadLine();
    }

    static void ReimportHTML()
    {
        var files = Directory.GetFiles("HTML");
        foreach (var file in files)
        {
            var name = file.Substring(file.LastIndexOf("\\") + 6);
            var newName = "HTML" + name + "_1.txt";
            var fullNewName = Path.Combine("HTML", newName);
            File.Move(file, fullNewName); 
        }
    }

    /// <summary>
    /// Check Exist Tags RC
    /// equipresources.rc - PUSH TRA JUST TEXT PARA POP
    /// </summary>
    static void ReadTagsHTML(string path)
    {
        if(!Directory.Exists(path))
        {
            Console.WriteLine($"Папка: {path} - не существует!");
            return;
        }

        var text = string.Empty;
        foreach (string f in Directory.GetFiles(path))
        {
            var d = File.ReadAllText(f, encoding: System.Text.Encoding.GetEncoding("UTF-16"));
            var xd = new XMLtoUnityFormatConverter(text);
            var data = xd.ReadXmlData(d, f);
            if (data.Count > 1)
            {
                Console.WriteLine("\n ЗАМЕНЁННЫЕ ТЕГИ: \n" + data[1] + "\n---------------------\n" + data[0]);
            }
        }
    }

    static void ApplyCommand(string command)
    {
        if (command.Contains("!!"))         // поиск текста по идентификатору
        {
            Console.Clear();
            Console.WriteLine("");

            var searchStr = command.Substring(command.IndexOf("!!") + 2);
            var data = Search(TypeSearch.Id, searchStr);
            foreach (var item in data)
            {
                Console.WriteLine($"=> [{item.NameResources}]  <{item.Key}>        {item.Value}");
                Console.WriteLine();
            }
        }
        else if (command.Contains("::"))    // поиск идентификатора по тексту
        {
            Console.Clear();
            Console.WriteLine("");

            if (command.Contains("|"))
            {
                var dll = command.Substring(command.IndexOf("|") + 1);
            }

            var searchStr = command.Substring(command.IndexOf("::") + 2);
            var data = Search(TypeSearch.Value, searchStr);
            foreach (var item in data)
            {
                Console.WriteLine($"=> [{item.NameResources}]  <{item.Key}>        {item.Value}");
                Console.WriteLine();
            }
        }
        else
        {
            var commands = command.Split(' ');

            if (commands.Length > 0)
            {
                if (commands.Length == 2)
                {
                    switch (commands[0])
                    {
                        case "clear":
                        case "c":
                            new ResourcesCreater(commands[1]).ClearAllData();
                            break;
                        case "rhtml":
                            ReadTagsHTML(commands[1]);
                            break;
                    }
                }
                if (commands.Length == 3)
                {
                    switch (commands[0])
                    {
                        case "g": // ищет все уникальные значения поля INI файла
                            ApplyAnalisINI("Analis\\" + commands[1], commands[2]);
                            break;
                        case "st":
                            new ResourcesCreater(commands[1]).CreateStringTableData(commands[2]);
                            break;
                        case "html":
                        case "h":
                            new ResourcesCreater(commands[1]).CreateHTMLData(commands[2]);
                            break;
                    }
                }
            }

            switch (command)
            {
                case "exit":
                case "q":
                case "e":
                    _initialized = false;
                    break;
                case "import":
                case "i":
                    ImportTestData();
                    break;
                case "all":
                case "a":
                    FullCreateResx();
                    break;
            }
        }
    }

    private static void ImportTestData()
    {
        Console.WriteLine("Start import test data...");
        string exePath = Assembly.GetExecutingAssembly().Location;
        string source = Path.Combine(Path.GetDirectoryName(exePath), "TestData");
        string target = Path.Combine(Path.GetDirectoryName(exePath), "INPUT");

        CopyDirectory(source, target);
        Console.WriteLine("Complete import test data");
    }

    public static void CopyDirectory(string sourceDir, string destinationDir, bool copySubDirs = true)
    {
        var dir = new DirectoryInfo(sourceDir);
        if (!dir.Exists)
            throw new DirectoryNotFoundException($"Исходная папка не найдена: {sourceDir}");

        // Создаём целевую папку, если не существует
        Directory.CreateDirectory(destinationDir);

        // Копируем файлы
        foreach (FileInfo file in dir.GetFiles())
        {
            string targetFilePath = Path.Combine(destinationDir, file.Name);
            file.CopyTo(targetFilePath, overwrite: true);
        }

        // Рекурсивно копируем подпапки
        if (copySubDirs)
        {
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir, copySubDirs);
            }
        }
    }

    private static void ApplyAnalisINI(string path, string keyPair)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"File: {path} not found");
            return;
        }

        var data = File.ReadAllLines(path);

        var list = new List<string>();
        foreach( var item in data) 
        { 
            if(item.Contains("="))
            {
                var keyVal = item.Split('=');
                var key = keyVal[0].Trim();
                var value = keyVal[1].Trim().Split(',');
                if(key == keyPair && !list.Contains(value[0]))
                {
                    list.Add(value[0]);
                    Console.WriteLine(value[0]);
                }
            }
        }
    }

    static void FullCreateResx()
    {
        var inputFolder = "INPUT";
        var _paths = GenerateOutputResx();    //пути до файлов ресурсов
        var _listInputPaths = new List<string>();

        var index = 0;
        foreach (var path in _paths)
        {
            var _nameInputPath = path.Substring(path.IndexOf("\\") + 1, path.LastIndexOf('_') - (path.IndexOf("\\") + 1));
            var nameInputPath = _nameInputPath.Substring(_nameInputPath.IndexOf("\\") + 1, _nameInputPath.Length - _nameInputPath.IndexOf("\\") - 1);
            _listInputPaths.Add(nameInputPath);
            GenerateResxData(inputFolder, nameInputPath, path, ref index, _paths.Count);
        }

        Console.WriteLine("[End] Please press Enter");
    }

    static void GenerateResxData(string inputFolder, string nameInputFolder, string nameOutputFolder, ref int index, int count)
    {
        var typeGenerate = nameOutputFolder.Substring(nameOutputFolder.LastIndexOf("_"));
        var _pathInfo = Path.Combine(nameInputFolder, "HTML");
        var pathInfo = Path.Combine(inputFolder, _pathInfo);
        var _pathName = Path.Combine(nameInputFolder, "data.txt");
        var pathName = Path.Combine(inputFolder, _pathName);

        if(typeGenerate.Contains("name"))
        { 
            if(File.Exists(pathName))
                new ResourcesCreater(nameOutputFolder).CreateStringTableData(pathName);
        }
        else
        {
            if(Directory.Exists(pathInfo))
                new ResourcesCreater(nameOutputFolder).CreateHTMLData(pathInfo);
        }

        index++;
        Console.WriteLine($"[{index}/{count}]:  {nameInputFolder}->{nameOutputFolder}");
    }

    static List<string> GenerateOutputResx()
    {
        var nameOut = "OUTPUT";
        var dateName = DateTime.Now.ToString("dd.MM.yyyy.hh.mm.ss");
        var dir = Path.Combine(nameOut, dateName);
        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        var paths = new List<string>();
        foreach(var name in ResourceData.NamesResorces)
        {
            var _path = Path.Combine(dir, name);
            paths.Add(_path);
            using (ResXResourceWriter resx = new ResXResourceWriter(_path)) { }
        }
        return paths;
    }

    static List<SearchInfo> Search(TypeSearch type, string value)
    {
        var searchInfo = new List<SearchInfo>();
        foreach (var name in ResourceData.NamesResorces)
        {
            var nameRes = name.Substring(0, name.IndexOf("."));
            var assembly = FLResources.ResControl.GetAssemblyByName(nameRes);
            var resource = new DataSetter().GetResource(nameRes, ResourceData.NamesResorces, "FLResources", assembly);
            var keys = resource.GetResourceSet(CultureInfo.InvariantCulture, true, true)
                .Cast<DictionaryEntry>()
                .Select(entry => entry.Key)
                .Cast<string>();
            var Data = keys.ToDictionary(
                key => key,
                key => resource.GetString(key, CultureInfo.GetCultureInfo("de")));

            var val = new Dictionary<string, string>();
            switch(type)
            {
                case TypeSearch.Id:
                    val = Data.Where(t => t.Key.ToLower() == value.ToLower()).ToDictionary(x => x.Key, x => x.Value);
                    break;
                case TypeSearch.Value: 
                    val = Data.Where(t => t.Value.ToLower().Contains(value.ToLower())).ToDictionary(x => x.Key, x => x.Value);
                    break;
            }

            if (val.Count > 0)
            {
                foreach (var kv in val)
                {
                    searchInfo.Add(new SearchInfo()
                    {
                        Key = kv.Key,
                        Value = kv.Value,
                        NameResources = name
                    });
                }
            }
        }
        return searchInfo;
    }
}
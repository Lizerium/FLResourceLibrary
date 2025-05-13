/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2025 15:25:18
 * Version: 1.0.1
 */

using System;

namespace FLEDId
{
    public enum DLLS
    {
        resources = 65535,
        infocards = 131071,
        misctext = 196607,
        nameresources = 262143,
        equipresources = 327679,
        offerbriberesources = 393215,
        misctextinfo2 = 458751,
        SBM2 = 524287,
        SBM3 = 589823,
        SBM = 655359
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Конвертирует идентификаторы из файлов INI (игры Freelancer Rebirth) (ids_name, ids_info) в те что зашиты в DLL файлы ресурсов и наобоорот\n\n" +
                    "Enter ids: \n" +
                    "Example №1: \n" +
                    ":2049,SBM3\n" +
                    "Example №2:\n" +
                    "!54320)");

                var command = Console.ReadLine();
                string[] words = command.Split(' ');

                foreach (string word in words)
                {
                    if (word.Contains(":") && word.Contains(","))
                    {
                        var idAndName = word.Split(',');
                        var id = idAndName[0].Substring(1, idAndName[0].Length - 1);

                        LoadIds(int.Parse(id), idAndName[1]);
                    }
                    if (word.Contains("!"))
                    {
                        var id = word.Substring(1, word.Length - 1);
                        LoadResourceIds(int.Parse(id));
                    }
                    if (word.Contains("quit"))
                    {
                        break;
                    }
                }

            }
        }

        static void LoadIds(int ids, string name)
        {
            Console.WriteLine("Load Start....\n");
            try
            {
                if (name == DLLS.resources.ToString())
                {
                    var id = ids + 65536 * 0;
                    Console.WriteLine($"DLL: {DLLS.resources} ID:{id}");
                }
                if (name ==  DLLS.infocards.ToString())
                {
                    var id = ids + 65536 * 1;
                    Console.WriteLine($"DLL: {DLLS.infocards} ID:{id}");
                }
                if (name == DLLS.misctext.ToString())
                {
                    var id = ids + 65536 * 2;
                    Console.WriteLine($"DLL: {DLLS.misctext} ID:{id}");
                }
                if (name == DLLS.nameresources.ToString())
                {
                    var id = ids + 65536 * 3;
                    Console.WriteLine($"DLL: {DLLS.nameresources} ID:{id}");
                }
                if (name == DLLS.equipresources.ToString())
                {
                    var id = ids + 65536 * 4;
                    Console.WriteLine($"DLL: {DLLS.equipresources} ID:{id}");
                }
                if (name == DLLS.offerbriberesources.ToString())
                {
                    var id = ids + 65536 * 5;
                    Console.WriteLine($"DLL: {DLLS.offerbriberesources} ID:{id}");
                }
                if (name == DLLS.misctextinfo2.ToString())
                {
                    var id = ids + 65536 * 6;
                    Console.WriteLine($"DLL: {DLLS.misctextinfo2} ID:{id}");
                }
                if (name == DLLS.SBM2.ToString())
                {
                    var id = ids + 65536 * 7;
                    Console.WriteLine($"DLL: {DLLS.SBM2} ID:{id}");
                }
                if (name == DLLS.SBM3.ToString())
                {
                    var id = ids + 65536 * 8;
                    Console.WriteLine($"DLL: {DLLS.SBM3} ID:{id}");
                }
                if (name == DLLS.SBM.ToString())
                {
                    var id = ids + 65536 * 9;
                    Console.WriteLine($"DLL: {DLLS.SBM} ID:{id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Load Stop....\n");
        }


       static void LoadResourceIds(int ids)
        {
            Console.WriteLine("Load Start.... \n");
            try
            {
                if (ids >= 0 && ids <= (int)DLLS.resources)
                {
                    var id = ids - 65536 * 0;
                    Console.WriteLine($"DLL: {DLLS.resources} ID:{id}");
                }
                if (ids >= (int)DLLS.resources && ids <= (int)DLLS.infocards)
                {
                    var id = ids - 65536 * 1;
                    Console.WriteLine($"DLL: {DLLS.infocards} ID:{id}");
                }
                if (ids >= (int)DLLS.infocards && ids <= (int)DLLS.misctext)
                {
                    var id = ids - 65536 * 2;
                    Console.WriteLine($"DLL: {DLLS.misctext} ID:{id}");
                }
                if (ids >= (int)DLLS.misctext && ids <= (int)DLLS.nameresources)
                {
                    var id = ids - 65536 * 3;
                    Console.WriteLine($"DLL: {DLLS.nameresources} ID:{id}");
                }
                if (ids >= (int)DLLS.nameresources && ids <= (int)DLLS.equipresources)
                {
                    var id = ids - 65536 * 4;
                    Console.WriteLine($"DLL: {DLLS.equipresources} ID:{id}");
                }
                if (ids >= (int)DLLS.equipresources && ids <= (int)DLLS.offerbriberesources)
                {
                    var id = ids - 65536 * 5;
                    Console.WriteLine($"DLL: {DLLS.offerbriberesources} ID:{id}");
                }
                if (ids >= (int)DLLS.offerbriberesources && ids <= (int)DLLS.misctextinfo2)
                {
                    var id = ids - 65536 * 6;
                    Console.WriteLine($"DLL: {DLLS.misctextinfo2} ID:{id}");
                }
                if (ids >= (int)DLLS.misctextinfo2 && ids <= (int)DLLS.SBM2)
                {
                    var id = ids - 65536 * 7;
                    Console.WriteLine($"DLL: {DLLS.SBM2} ID:{id}");
                }
                if (ids >= (int)DLLS.SBM2 && ids <= (int)DLLS.SBM3)
                {
                    var id = ids - 65536 * 8;
                    Console.WriteLine($"DLL: {DLLS.SBM3} ID:{id}");
                }
                if (ids >= (int)DLLS.SBM3 && ids <= (int)DLLS.SBM)
                {
                    var id = ids - 65536 * 9;
                    Console.WriteLine($"DLL: {DLLS.SBM} ID:{id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Load Stop....\n");
        }
    }
}

/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:08:13
 * Version: 1.0.3
 */

using FLCore;
using FLData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace FLResources
{
    public enum SearchDll
    {
        Resources = 65535,
        InfoCards = 131071,
        MiscText = 196607,
        NameResources = 262143,
        EquipResources = 327679,
        OfferBribeResources = 393215,
        MiscTextInfo2 = 458751,
        SBM2 = 524287,
        SBM3 = 589823,
        SBM = 655359,
        none
    }

    public class ResControl : IResources
    {
        public Dictionary<string, string> Data;
        public List<int> Ids;

        public ResControl()
        {
            Data = new Dictionary<string, string>();
        }

        /// <summary>
        /// Подаём число из INI файла для ids_name или ids_info 
        /// 
        /// получаем имя DLL файла и индекс строки с данными
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>DLL and id</returns>
        public Dictionary<string, int> LoadIds(int ids)
        {
            try
            {
                if (ids >= 0 && ids <= (int)SearchDll.Resources)
                {
                    var id = ids - 65536 * 0;
                    return new Dictionary<string, int> { { SearchDll.Resources.ToString(), id } };
                }
                if (ids >= (int)SearchDll.Resources && ids <= (int)SearchDll.InfoCards)
                {
                    var id = ids - 65536 * 1;
                    return new Dictionary<string, int> { { SearchDll.InfoCards.ToString(), id } };
                }
                if (ids >= (int)SearchDll.InfoCards && ids <= (int)SearchDll.MiscText)
                {
                    var id = ids - 65536 * 2;
                    return new Dictionary<string, int> { { SearchDll.MiscText.ToString(), id } };
                }
                if (ids >= (int)SearchDll.MiscText && ids <= (int)SearchDll.NameResources)
                {
                    var id = ids - 65536 * 3;
                    return new Dictionary<string, int> { { SearchDll.NameResources.ToString(), id } };
                }
                if (ids >= (int)SearchDll.NameResources && ids <= (int)SearchDll.EquipResources)
                {
                    var id = ids - 65536 * 4;
                    return new Dictionary<string, int> { { SearchDll.EquipResources.ToString(), id } };
                }
                if (ids >= (int)SearchDll.EquipResources && ids <= (int)SearchDll.OfferBribeResources)
                {
                    var id = ids - 65536 * 5;
                    return new Dictionary<string, int> { { SearchDll.OfferBribeResources.ToString(), id } };
                }
                if (ids >= (int)SearchDll.OfferBribeResources && ids <= (int)SearchDll.MiscTextInfo2)
                {
                    var id = ids - 65536 * 6;
                    return new Dictionary<string, int> { { SearchDll.MiscTextInfo2.ToString(), id } };
                }
                if (ids >= (int)SearchDll.MiscTextInfo2 && ids <= (int)SearchDll.SBM2)
                {
                    var id = ids - 65536 * 7;
                    return new Dictionary<string, int> { { SearchDll.SBM2.ToString(), id } };
                }
                if (ids >= (int)SearchDll.SBM2 && ids <= (int)SearchDll.SBM3)
                {
                    var id = ids - 65536 * 8;
                    return new Dictionary<string, int> { { SearchDll.SBM3.ToString(), id } };
                }
                if (ids >= (int)SearchDll.SBM3 && ids <= (int)SearchDll.SBM)
                {
                    var id = ids - 65536 * 9;
                    return new Dictionary<string, int> { { SearchDll.SBM.ToString(), id } };
                }
                return new Dictionary<string, int> { { SearchDll.none.ToString(), -1 } };
            }
            catch
            {
                return new Dictionary<string, int> { { SearchDll.none.ToString(), -1 } };
            }
        }

        /// <summary>
        /// Получает значение ресурса по ключу из RESX файлов в Properties проекта
        /// 
        /// OfferBribeResources_name
        /// NameResources_name
        /// EquipResources_name
        /// SBM3_name
        /// SBM2_name
        /// SBM_name
        /// SBM_info
        /// EquipResources_info
        /// MiscTextInfo2_info
        /// InfoCards_info
        /// MiscText_info
        /// SBM3_info
        /// 
        /// </summary>
        /// <param name="id">Идентификатор ресурса</param>
        /// <returns>StatusHandle</returns>
        public StatusHandle GetData(string nameResources, int id)
        {
            try
            {
                //получаю всю информацию из ресурса
                var code = GetAllResources(nameResources);
                if(code.Code == ErrorCode.Error || code.Code == ErrorCode.Exception) return code;

                //получаю конкретное значение из информации
                if (Data.ContainsKey(id.ToString()))
                {
                    return new StatusHandle()
                    {
                        Data = Data[id.ToString()].ToString(),
                        Code = ErrorCode.Ok,
                        Message = "OK",
                    };
                }
                else return new StatusHandle()
                {
                    Data = null,
                    Code = ErrorCode.Error,
                    Message = "data not valid key: " + id,
                };
            }
            catch (Exception exception)
            {
                return new StatusHandle()
                {
                    Data = null,
                    Code = ErrorCode.Exception,
                    Message = $"[GetData] {exception.Message}",
                };
            }
        }

        public static Assembly GetAssemblyByName(string name)
        {
            Type[] typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "FLResources.Properties").ToArray();
            return typelist.SingleOrDefault(type => type.Name  == name).Assembly;
        }

        private StatusHandle GetAllResources(string nameResources)
        {
            var nameRes = string.Empty;
            Assembly assembly = null;
            ResourceManager resource = null;
            try
            {
                assembly = GetAssemblyByName(nameResources);
                resource = new DataSetter().GetResource(nameResources, ResourceData.NamesResorces, "FLResources", assembly);

                if (resource == null)
                {
                    return new StatusHandle()
                    {
                        Data = null,
                        Code = ErrorCode.Error,
                        Message = $"resource not found: name - {nameResources} assembly - {assembly.FullName}",
                    };
                }

                var keys = resource.GetResourceSet(CultureInfo.InvariantCulture, true, true)
                        .Cast<DictionaryEntry>()
                        .Select(entry => entry.Key)
                        .Cast<string>();
                Data = keys.ToDictionary(
                        key => key,
                        key => resource.GetString(key, CultureInfo.GetCultureInfo("de")));
                Ids = Data.Keys.Select(int.Parse).ToList();

                return new StatusHandle()
                {
                    Data = null,
                    Code = ErrorCode.Ok,
                    Message = "OK",
                };
            }
            catch (Exception exception)
            {
                return new StatusHandle()
                {
                    Data = null,
                    Code = ErrorCode.Exception,
                    Message = $"[GetAllResources] {exception.Message}",
                };
            }
        }
    }
}

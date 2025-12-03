/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 декабря 2025 11:20:36
 * Version: 1.0.100
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLGenerateLibrary
{
    public class NamesResourcesDLL
    {
        /// <summary>
        /// Тип DLL с названием
        /// </summary>
        public TypeResourcesDllName DllIdsName;
        /// <summary>
        /// Адрес до названия
        /// </summary>
        public long IDName;
        /// <summary>
        /// Описания
        /// </summary>
        public List<NamesResourcesDescDLL> Descriptions;
    }
}
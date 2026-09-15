/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 сентября 2026 07:36:40
 * Version: 1.0.390
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
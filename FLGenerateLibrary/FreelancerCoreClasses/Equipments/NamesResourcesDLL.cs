/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 августа 2026 06:52:11
 * Version: 1.0.354
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
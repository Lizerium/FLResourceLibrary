/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 сентября 2026 09:34:16
 * Version: 1.0.396
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class LightAnimStats
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Header("Имя")]
        public string Nickname;

        /// <summary>
        /// Вспышка
        /// </summary>
        public List<FraneLA> Frame;
    }
}
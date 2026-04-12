/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:15:47
 * Version: 1.0.231
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
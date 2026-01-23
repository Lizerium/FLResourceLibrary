/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 января 2026 07:56:30
 * Version: 1.0.151
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class ShieldStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Модель
        /// </summary>
        [Header("Модель")]
        public string DAArchetype;

        /// <summary>
        /// Точка монтирования
        /// </summary>
        [Header("Точка монтирования")]
        public string HPChild;
    }
}
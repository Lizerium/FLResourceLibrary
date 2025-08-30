/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:35:07
 * Version: 1.0.5
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
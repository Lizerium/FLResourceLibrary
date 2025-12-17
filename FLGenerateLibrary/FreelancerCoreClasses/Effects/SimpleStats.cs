/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:25:24
 * Version: 1.0.114
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class SimpleStats
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Модель
        /// </summary>
        public string DAArchetype;

        /// <summary>
        /// Материал
        /// </summary>
        public string MaterialLibrary;

        /// <summary>
        /// Масса
        /// </summary>
        public int Mass;

        /// <summary>
        /// Эффект взрыва
        /// </summary>
        public ExplosionStats ExplosionArch;
    }
}
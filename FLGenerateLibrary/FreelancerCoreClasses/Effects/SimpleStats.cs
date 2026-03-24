/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:54:19
 * Version: 1.0.211
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
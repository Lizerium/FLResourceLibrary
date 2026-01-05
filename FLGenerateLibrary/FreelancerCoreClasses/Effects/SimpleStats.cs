/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 января 2026 15:47:04
 * Version: 1.0.133
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
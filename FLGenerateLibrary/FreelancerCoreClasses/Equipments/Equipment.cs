/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 июня 2026 13:26:11
 * Version: 1.0.293
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class Equipment : Item
    {
        /// <summary>
        /// Идентификатор имени корабля
        /// </summary>
        [Header("Идентификатор имени корабля")]
        public int IdsName;
        /// <summary>
        /// Идентификатор описания корабля
        /// </summary>
        [Header("Идентификатор описания корабля")]
        public int IdsInfo;

        /// <summary>
        /// Человекочитаемая информация о объекте
        /// </summary>
        [Header("Человекочитаемая информация о объекте")]
        public List<NamesResourcesDLL> IdsData;
    }
}
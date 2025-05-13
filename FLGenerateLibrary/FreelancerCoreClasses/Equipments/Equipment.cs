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
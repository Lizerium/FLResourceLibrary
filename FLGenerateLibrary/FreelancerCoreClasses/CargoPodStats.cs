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
    public class CargoPodStats : Equipment
    {
        /// <summary>
        /// Никнейм
        /// </summary>
        [Header("Никнейм")]
        public string Nickname;

        /// <summary>
        /// Дистанции LOD
        /// </summary>
        [Header("Дистанции LOD")]
        public List<string> LODRanges;

        /// <summary>
        /// Модель
        /// </summary>
        [Header("Модель")]
        public string DAArchetype;

        /// <summary>
        /// Материал
        /// </summary>
        [Header("Материал")]
        public string MaterialLibrary;

        /// <summary>
        /// Количество здоровья у предмета
        /// </summary>
        [Header("Количество здоровья у предмета")]
        public long HitPts;

        /// <summary>
        /// "Вес" оборудования, добавляется к корабельному для расчета инерции
        /// </summary>
        [Header("Вес оборудования, добавляется к корабельному для расчета инерции")]
        public float Mass;

        /// <summary>
        /// Устанавливает точку крепления , от которой CMP или 3DB оружия будут прикреплены к точке крепления корабля/солнца.
        /// </summary>
        [Header("Устанавливает точку крепления , от которой CMP или 3DB оружия будут прикреплены к точке крепления корабля/солнца.")]
        public string HPСhild;

        /// <summary>
        /// Импульс родительского обьекта
        /// </summary>
        [Header("Импульс родительского обьекта")]
        public float ParentImpulse;

        /// <summary>
        /// Импульс дочернего обьекта
        /// </summary>
        [Header("Импульс дочернего обьекта")]
        public float ChildImpulse;

        /// <summary>
        /// Тип обломка
        /// </summary>
        [Header("Тип обломка")]
        public DebrisStats DebrisType;

        /// <summary>
        /// Эффект взрыва - вспышка с осколками
        /// </summary>
        [Header("Эффект взрыва - вспышка с осколками")]
        public ExplosionStats ExplosionArch;

        /// <summary>
        /// Иконка
        /// </summary>
        [Header("Иконка")]
        public string ItemIcon;
    }
}
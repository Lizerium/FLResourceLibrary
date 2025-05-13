/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2025 15:25:18
 * Version: 1.0.1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class RepairKitStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор частицы
        /// </summary>
        [Header("Уникальный идентификатор частицы")]
        public string Nickname;

        /// <summary>
        /// Вес в грузовом отсеке
        /// </summary>
        [Header("Вес в грузовом отсеке")]
        public float Volume;

        /// <summary>
        /// Единица "веса" частицы(для расчета инерции), энергетическому оружию всегда 1
        /// </summary>
        [Header("Единица веса частицы(для расчета инерции), энергетическому оружию всегда 1")]
        public float Mass;

        /// <summary>
        /// Количество здоровья
        /// </summary>
        [Header("Количество здоровья")]
        public long HitPts;

        /// <summary>
        /// Тип контейнера
        /// </summary>
        [Header("Тип контейнера")]
        public LootCrateStats LootAppearance;

        /// <summary>
        /// Cколько единиц содержится в контейнере
        /// </summary>
        [Header("Cколько единиц содержится в контейнере")]
        public int UnitsPerContainer;

        /// <summary>
        /// Способность выпадать из трюма при смерти игрока (значения true/false)
        /// </summary>
        [Header("Способность выпадать из трюма при смерти игрока (значения true/false)")]
        public bool Lootable = true;
    }
}
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
    public class PowerStats : Equipment
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
        /// Адрес до модельки 3db в оригинале
        /// </summary>
        [Header("Адрес до модельки 3db в оригинале")]
        public string DAArchetype;

        /// <summary>
        /// Материал
        /// </summary>
        [Header("Материал")]
        public string MaterialLibrary;

        /// <summary>
        /// Ёмкость
        /// </summary>
        [Header("Ёмкость")]
        public int Capacity;

        /// <summary>
        /// Насколько быстро он перезаряжается.(коэфф скорости заряда энергии)
        /// </summary>
        [Header("Насколько быстро он перезаряжается.")]
        public int ChargeRate;

        /// <summary>
        /// Объём энергии форсажа
        /// </summary>
        [Header("Объём энергии форсажа")]
        public int ThrustCapacity;

        /// <summary>
        /// Мощность востановления энергии форсажа
        /// </summary>
        [Header("Мощность востановления энергии форсажа")]
        public int ThrustChargeRate;

        /// <summary>
        /// Способность выпадать из трюма при смерти игрока (значения true/false)
        /// </summary>
        [Header("Способность выпадать из трюма при смерти игрока (значения true/false)")]
        public bool Lootable = true;
    }
}
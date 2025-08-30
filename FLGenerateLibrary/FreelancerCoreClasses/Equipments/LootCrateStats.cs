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
    public class LootCrateStats : Equipment
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Header("Имя")]
        public string Nickname;

        /// <summary>
        /// Адрес до модели
        /// </summary>
        [Header("Адрес до модели")]
        public string DAArchetype;

        /// <summary>
        /// Диапазон видимости корабля
        /// </summary>
        [Header("Диапазон видимости корабля")]
        public List<string> LODRanges;

        /// <summary>
        /// Здоровье до уничтожения
        /// </summary>
        [Header("Здоровье до уничтожения")]
        public long HitPts = 0;

        /// <summary>
        /// Масса
        /// </summary>
        [Header("Масса")]
        public int Mass = 0;

        /// <summary>
        /// Эффект взрыва
        /// </summary>
        [Header("Эффект взрыва")]
        public ExplosionStats ExplosionArch;

        /// <summary>
        /// Громкость
        /// </summary>
        [Header("Громкость")]
        public float Volume = 0;

        /// <summary>
        /// Внешний вид добычи (как он выглядит, когда его разграбили или добыли, снова выберите значение по умолчанию из аналогичного товара)
        /// </summary>
        [Header("Внешний вид добычи")]
        public string LootAppearance;

        /// <summary>
        /// Cколько единиц содержится в контейнере
        /// </summary>
        [Header("Cколько единиц содержится в контейнере")]
        public int UnitPerContainer;

        /// <summary>
        /// Можно ли притянуть захватом
        /// </summary>
        [Header("Можно ли притянуть захватом")]
        public bool Lootable = true;

        /// <summary>
        /// Адрес до материала
        /// </summary>
        [Header("Адрес до материала")]
        public string MaterialLibrary;
    }
}
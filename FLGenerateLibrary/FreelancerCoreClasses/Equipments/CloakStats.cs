/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:08:13
 * Version: 1.0.3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class CloakStats : Equipment
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Header("Имя")]
        public string Nickname;

        /// <summary>
        /// Здоровье до уничтожения
        /// </summary>
        [Header("Здоровье до уничтожения")]
        public long HitPts = 0;

        /// <summary>
        /// Адрес до модели
        /// </summary>
        [Header("Адрес до модели")]
        public string DAArchetype;

        /// <summary>
        /// Адрес до материала
        /// </summary>
        [Header("Адрес до материала")]
        public string MaterialLibrary;

        /// <summary>
        /// Диапазон видимости корабля
        /// </summary>
        [Header("Диапазон видимости корабля")]
        public List<string> LODRanges;

        /// <summary>
        /// Диапазон видимости
        /// </summary>
        [Header("Диапазон видимости")]
        public List<string> MedmLODOp;

        /// <summary>
        /// Диапазон видимости
        /// </summary>
        [Header("Диапазон видимости корабля")]
        public List<string> HeighLODOp;

        /// <summary>
        /// Точка монтирования
        /// </summary>
        [Header("Точка монтирования")]
        public string HPChild;

        /// <summary>
        /// Масса
        /// </summary>
        [Header("Масса")]
        public int Mass = 0;

        /// <summary>
        /// Громкость
        /// </summary>
        [Header("Громкость")]
        public int Volume = 0;

        /// <summary>
        /// Абсолютное время в невидимости
        /// </summary>
        [Header("Абсолютное время в невидимости")]
        public float CloakinTime = 0;

        /// <summary>
        /// Относительное время в невидимости
        /// </summary>
        [Header("Относительное время в невидимости")]
        public float CloakoutTime = 0;

        /// <summary>
        /// Абсолютный эффект невидимости
        /// </summary>
        [Header("Абсолютный эффект невидимости")]
        public EffectMain CloakinFX;

        /// <summary>
        /// Относительный эффект невидимости
        /// </summary>
        [Header("Относительный эффект невидимости")]
        public EffectMain CloakinOutFX;

        /// <summary>
        /// Абсолютный эффект невидимости
        /// </summary>
        [Header("Абсолютный эффект невидимости")]
        public CloakinFX CloakinFXMy;

        /// <summary>
        /// Относительный эффект невидимости
        /// </summary>
        [Header("Относительный эффект невидимости")]
        public CloakinFX CloakinOutFXMy;

        /// <summary>
        /// Можно ли притянуть захватом
        /// </summary>
        [Header("Можно ли притянуть захватом")]
        public bool Lootable = true;

        /// <summary>
        /// Энергия для использования
        /// </summary>
        [Header("Энергия для использования")]
        public float PowerUsage = 0;
    }
}
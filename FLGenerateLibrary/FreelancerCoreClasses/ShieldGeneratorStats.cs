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
    public class ShieldGeneratorStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

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
        /// Дистанции LOD
        /// </summary>
        [Header("Дистанции LOD")]
        public List<string> LODRanges;

        /// <summary>
        /// Масса
        /// </summary>
        [Header("Масса")]
        public int Mass;

        /// <summary>
        /// Вес в грузовом отсеке
        /// </summary>
        [Header("Вес в грузовом отсеке")]
        public float Volume;

        /// <summary>
        /// Здоровье до уничтожения
        /// </summary>
        [Header("Здоровье до уничтожения")]
        public long HitPts = 0;

        /// <summary>
        /// Точка монтирования
        /// </summary>
        [Header("Точка монтирования")]
        public string HPChild;

        /// <summary>
        /// Тип обломка
        /// </summary>
        [Header("Тип обломка")]
        public DebrisStats DebrisType;

        /// <summary>
        /// Скорость регенерации. Лучше 10 % от номинала «максимальная_емкость».
        /// </summary>
        [Header("Скорость регенерации")]
        public float RegenerationRate;

        /// <summary>
        /// Постоянное энергопотребление.
        /// </summary>
        [Header("Постоянное энергопотребление")]
        public int СonstantPowerDraw;

        /// <summary>
        /// Восстановление энергопотребления
        /// </summary>
        [Header("Восстановление энергопотребления")]
        public int RebuildPowerDraw;

        /// <summary>
        /// Здоровье щита.
        /// </summary>
        [Header("Здоровье(ёмкость) щита.")]
        public float MaxCapacity;

        /// <summary>
        /// Время восстановления в автономном режиме
        /// ниже этого значения 1 бои становятся слишком тяжелыми.
        /// </summary>
        [Header("Время восстановления в автономном режиме.")]
        public float OfflineRebuildTime;

        /// <summary>
        /// Порог автономного режима.
        /// </summary>
        [Header("Порог автономного режима.")]
        public float OfflineThreshold;

        /// <summary>
        /// Эффекты удара по щиту (порог здоровья - эффект)
        /// </summary>
        [Header("Эффекты удара по щиту (порог здоровья - эффект).")]
        public List<ShieldHitEffectsSt> ShieldHitEffects;

        /// <summary>
        /// Звук разрушения щита.
        /// </summary>
        [Header("Звук разрушения щита.")]
        public SoundStats ShieldCollapseSound;

        /// <summary>
        /// Эффект разрушения щита.
        /// </summary>
        [Header("Эффект разрушения щита.")]
        public EffectMain ShieldCollapseParticle;

        /// <summary>
        /// Звук восстановления щита.
        /// </summary>
        [Header("Звук восстановления щита.")]
        public SoundStats ShieldRebuiltSound;

        /// <summary>
        /// Тип щита.
        /// </summary>
        [Header("Тип щита.")]
        public ShieldType ShieldType;

        /// <summary>
        /// Взрывостойкость.
        /// </summary>
        [Header("Взрывостойкость.")]
        public float ExplosionResistance;

        /// <summary>
        /// Импульс родительского обьекта
        /// </summary>
        [Header("Импульс родительского обьекта")]
        public int ParentImpulse;

        /// <summary>
        /// Импульс дочернего обьекта
        /// </summary>
        [Header("Импульс дочернего обьекта")]
        public int ChildImpulse;

        /// <summary>
        /// Прочность
        /// </summary>
        [Header("Прочность")]
        public float Toughness;

        /// <summary>
        /// Тип генератора щита
        /// </summary>
        [Header("Тип генератора щита")]
        public ShieldGeneratorType HpType;

        /// <summary>
        /// Взрыв при разрушении.
        /// </summary>
        [Header("Взрыв при разрушении.")]
        public ExplosionStats SeparationExplosion;

        /// <summary>
        /// Способность выпадать из трюма при смерти игрока (значения true/false)
        /// </summary>
        [Header("Способность выпадать из трюма при смерти игрока (значения true/false)")]
        public bool Lootable;

        /// <summary>
        /// ?
        /// </summary>
        [Header("?")]
        public string EnvmapMaterial;

        /// <summary>
        /// Сила замедления
        /// </summary>
        [Header("Сила замедления")]
        public float LinearDrag;
    }
}
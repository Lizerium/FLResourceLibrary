/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2025 06:52:13
 * Version: 1.0.4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class ThrusterStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор частицы
        /// </summary>
        [Header("Уникальный идентификатор частицы")]
        public string Nickname;

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
        /// Точка монтирования
        /// </summary>
        [Header("Точка монтирования")]
        public string HPChild;

        /// <summary>
        /// Количество здоровья
        /// </summary>
        [Header("Количество здоровья")]
        public int HitPts;

        /// <summary>
        /// Процент сопротивления взрыву
        /// </summary>
        [Header("Процент сопротивления взрыву")]
        public float ExplosionResistance;

        /// <summary>
        /// Тип обломка
        /// </summary>
        [Header("Тип обломка")]
        public DebrisStats DebrisType;

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
        /// Настройка скорости. Значение составляет 1/600
        /// от прироста скорости. Все двигатели имеют max_force 72000, что
        /// означает прирост скорости на 120.
        /// </summary>
        [Header("Настройка скорости")]
        public int MaxForce;

        /// <summary>
        /// Эффект ускорителя
        /// </summary>
        [Header("Эффект ускорителя")]
        public EffectMain Particles;

        /// <summary>
        /// Точка монтирования эффекта
        /// </summary>
        [Header("Точка монтирования эффекта")]
        public string HPParticles;

        /// <summary>
        /// Трата энергии  
        /// </summary>
        [Header("Трата энергии")]
        public float PowerUsage;

        /// <summary>
        /// Способность выпадать из трюма при смерти игрока (значения true/false)
        /// </summary>
        [Header("Способность выпадать из трюма при смерти игрока (значения true/false)")]
        public bool Lootable = true;

        /// <summary>
        /// Взрыв при разрушении.
        /// </summary>
        [Header("Взрыв при разрушении.")]
        public ExplosionStats SeparationExplosion;

        /// <summary>
        /// Дистанции LOD
        /// </summary>
        [Header("Дистанции LOD")]
        public List<string> LODRanges;

        /// <summary>
        /// Можно ли уничтожить (false - да, true - нет)
        /// </summary>
        [Header("Можно ли уничтожить")]
        public bool Indestructible;
    }
}
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
    public class MineDropperStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор частицы
        /// </summary>
        [Header("Уникальный идентификатор частицы")]
        public string Nickname;

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
        /// Единица "веса" частицы(для расчета инерции), энергетическому оружию всегда 1
        /// </summary>
        [Header("Единица веса частицы(для расчета инерции), энергетическому оружию всегда 1")]
        public float Mass;

        /// <summary>
        /// Вес в грузовом отсеке
        /// </summary>
        [Header("Вес в грузовом отсеке")]
        public float Volume;

        /// <summary>
        /// Самоуничтожение оружия при выстреле
        /// </summary>
        [Header("Самоуничтожение оружия при выстреле")]
        public int DamagePerFire;

        /// <summary>
        /// Энергия для использования
        /// </summary>
        [Header("Энергия для использования")]
        public float PowerUsage = 0;

        /// <summary>
        /// Задержка между выстрелами (в секундах)
        /// </summary>
        [Header("Задержка между выстрелами (в секундах)")]
        public float RefireDelay;

        /// <summary>
        /// Скорость полета частицы
        /// </summary>
        [Header("Скорость полета частицы")]
        public float MuzzleVelocity;

        /// <summary>
        /// "Сложность", подразумевается использование неписями, но этот параметр ни начто не влияет
        /// </summary>
        [Header("Сложность, подразумевается использование неписями, но этот параметр ни начто не влияет")]
        public float Toughness;

        /// <summary>
        /// Уникальный идентификатор используемого припаса
        /// </summary>
        [Header("Уникальный идентификатор используемого припаса")]
        public MineStats ProjectileArchetype;

        /// <summary>
        /// Звук, который издает пистолет при выстреле, но он не может стрелять (на крейсерском ходу, на полосе движения)
        /// </summary>
        [Header("Звук, который издает пистолет при выстреле")]
        public SoundStats DryFireSound;

        /// <summary>
        /// Взрыв при разрушении.
        /// </summary>
        [Header("Взрыв при разрушении.")]
        public ExplosionStats SeparationExplosion;

        /// <summary>
        /// Можно ли притянуть захватом
        /// </summary>
        [Header("Можно ли притянуть захватом")]
        public bool Lootable = true;

        /// <summary>
        /// Дальность видимости модели оружия
        /// </summary>
        [Header("Дальность видимости модели оружия")]
        public List<string> LODRanges;
    }
}
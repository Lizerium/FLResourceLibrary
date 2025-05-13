using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class CounterMeasureDropperStats : Equipment
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
        /// Флеш - эффект вспышки при выстреле
        /// </summary>
        [Header("Флеш - эффект вспышки при выстреле")]
        public EffectMain FlashParticleName;

        /// <summary>
        /// Радиус вспышки при динамическом освещении
        /// </summary>
        [Header("Радиус вспышки при динамическом освещении")]
        public int FlashRadius;

        /// <summary>
        /// Анимация динамического освещения вспышки
        /// </summary>
        [Header("Анимация динамического освещения вспышки")]
        public LightAnimStats LightAnim;

        /// <summary>
        /// Уникальный идентификатор используемого припаса
        /// </summary>
        [Header("Уникальный идентификатор используемого припаса")]
        public CounterMeasureStats ProjectileArchetype;

        /// <summary>
        /// Взрыв при разрушении.
        /// </summary>
        [Header("Взрыв при разрушении.")]
        public ExplosionStats SeparationExplosion;

        /// <summary>
        /// ?
        /// </summary>
        [Header("?")]
        public int AIRange;

        /// <summary>
        /// Можно ли притянуть захватом
        /// </summary>
        [Header("Можно ли притянуть захватом")]
        public bool Lootable = true;

        /// <summary>
        /// Линейный противовес. Т.е. это как на круиз встаешь на КЭ и тебя останавливает потихоньку
        /// </summary>
        [Header("Линейный противовес")]
        public float LinearDrag;

    }
}
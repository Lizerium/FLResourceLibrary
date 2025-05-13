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
    public class CounterMeasureStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор частицы
        /// </summary>
        [Header("Уникальный идентификатор частицы")]
        public string Nickname;

        /// <summary>
        /// Количество здоровья
        /// </summary>
        [Header("Количество здоровья")]
        public int HitPts;

        /// <summary>
        /// Тип контейнера
        /// </summary>
        [Header("Тип контейнера")]
        public LootCrateStats LootAppearance;

        /// <summary>
        /// Cколько единиц содержится в контейнере
        /// </summary>
        [Header("Cколько единиц содержится в контейнере")]
        public int UnitPerContainer;

        /// <summary>
        /// Звук выстрела
        /// </summary>
        [Header("Звук выстрела")]
        public SoundStats OneShotSound;

        /// <summary>
        /// Принудительно ориентирует снаряд на точку крепления HpFire пушки.
        /// Если установлено значение true, оружие не сможет стрелять из ствола под углом.
        /// Это означает, что если оружие не может точно направиться в направлении своей цели
        /// (обычно из-за слишком маленькой дальности стрельбы, установленной точкой
        /// крепления на корабле/солнце), оно будет стрелять в неправильном направлении.
        /// Если установлено значение false, он сможет стрелять внутри конуса,
        /// как определено MUZZLE_CONE_ANGLE в файле Constants.ini.
        /// </summary>
        [Header("Стрельба под углом")]
        public bool ForceGunOri;

        /// <summary>
        /// Относится к эффекту , который будет использоваться для снарядов.
        /// </summary>
        [Header("Относится к эффекту , который будет использоваться для снарядов.")]
        public EffectMain ConstEffect;

        /// <summary>
        /// Время жизни частицы(процент от muzzle_velocity) для конфигурирования дальности
        /// </summary>
        [Header("Время жизни частицы(процент от muzzle_velocity) для конфигурирования дальности")]
        public float Lifetime;

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
        /// Время в секундах, в течение которого владелец не может активировать мину.
        /// </summary>
        [Header("Время в секундах, в течение которого владелец не может активировать мину.")]
        public int OwnerSafeTime;

        /// <summary>
        /// Требуемость боеприпасов(значения true/false)
        /// </summary>
        [Header("Требуемость боеприпасов(значения true/false)")]
        public bool RequiresAmmo;

        /// <summary>
        /// Линейный противовес. Т.е. это как на круиз встаешь на КЭ и тебя останавливает потихоньку
        /// </summary>
        [Header("Линейный противовес")]
        public float LinearDrag;

        /// <summary>
        /// Диапазон захвата 
        /// </summary>
        [Header("Диапазон захвата")]
        public int Range;

        /// <summary>
        /// Процент отклонения
        /// </summary>
        [Header("Процент отклонения")]
        public float DiversionPctg;
    }
}
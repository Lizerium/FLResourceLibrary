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
using UnityEngine.Serialization;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class MineStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор частицы
        /// </summary>
        [Header("Уникальный идентификатор частицы")]
        public string Nickname;

        /// <summary>
        /// Эффект взрыва
        /// </summary>
        [Header("Эффект взрыва")]
        public ExplosionStats ExplosionArch;

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
        /// Требуемость боеприпасов(значения true/false)
        /// </summary>
        [Header("Требуемость боеприпасов(значения true/false)")]
        public bool RequiresAmmo;

        /// <summary>
        /// Количество здоровья
        /// </summary>
        [Header("Количество здоровья")]
        public int HitPts;

        /// <summary>
        /// Звук выстрела
        /// </summary>
        [Header("Звук выстрела")]
        public SoundStats OneShotSound;

        /// <summary>
        /// Может работать только с ракетами.
        /// Устанавливает радиус, в пределах которого снаряд
        /// взорвется вместо того, чтобы должным образом столкнуться с целью.
        /// </summary>
        [Header("Время дистанционной детонации")]
        public float DetonationDist;

        /// <summary>
        /// Время жизни частицы(процент от muzzle_velocity) для конфигурирования дальности
        /// </summary>
        [Header("Время жизни частицы(процент от muzzle_velocity) для конфигурирования дальности")]
        public float Lifetime;

        /// <summary>
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
        /// Линейный противовес. Т.е. это как на круиз встаешь на КЭ и тебя останавливает потихоньку
        /// </summary>
        [Header("Линейный противовес")]
        public float LinearDrag;

        /// <summary>
        /// Расстояние в метрах, на котором мина начнет двигаться.
        /// </summary>
        [Header("Расстояние в метрах, на котором мина начнет двигаться.")]
        public int SeekDist;

        /// <summary>
        /// Максимальная скорость мины.
        /// Это не зависит от скорости корабля.
        /// («нормальные» скорости снаряда добавляются к текущей
        /// скорости движения стреляющего корабля)
        /// </summary>
        [Header("Максимальная скорость мины.")]
        public int TopSpeed;

        /// <summary>
        /// Ускорение мины в м/с^2 до достижения максимальной скорости.
        /// </summary>
        [Header("Ускорение мины в м/с^2 до достижения максимальной скорости.")]
        public int Acceleration;

        /// <summary>
        /// Относится к эффекту , который будет использоваться для снарядов.
        /// </summary>
        [Header("Относится к эффекту , который будет использоваться для снарядов.")]
        public EffectMain ConstEffect;

        /// <summary>
        /// Число в боезапасе
        /// </summary>
        [Header("Число в боезапасе")]
        public int AmmoLimit;

        /// <summary>
        /// Дальность видимости модели оружия
        /// </summary>
        [FormerlySerializedAs("LODranges")]
        [Header("Дальность видимости модели оружия")]
        public List<string> LODRanges;
    }
}
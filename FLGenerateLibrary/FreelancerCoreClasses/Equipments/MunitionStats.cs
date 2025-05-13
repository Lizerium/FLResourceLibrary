using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class MunitionStats : Equipment
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
        /// Тип оборудования
        /// </summary>
        [Header("Тип оборудования")]
        public MunitionHpType HpType;

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
        /// Звук выстрела
        /// </summary>
        [Header("Звук выстрела")]
        public SoundGfStats GfOneShotSound;

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
        /// Относится к двигателю , который будет использоваться, если необходимо.
        /// </summary>
        [Header("Двигатель ракеты или торпеды")]
        public MotorStats Motor;

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
        /// Относится к эффекту , который будет использоваться для снарядов.
        /// </summary>
        [Header("Относится к эффекту , который будет использоваться для снарядов.")]
        public EffectMain ConstEffect;

        /// <summary>
        /// Если оружие представляет собой ракету, определяет точку крепления ,
        /// из которой будет излучаться эффект , определенный const_effect .
        /// </summary>
        [Header("Точка крепления const_effect к ракете")]
        public string HPTrailParent;

        /// <summary>
        /// Используйте, чтобы превратить оружие в ракету. Может быть либо LOCK , либо DUMB , причем первый создает следящую ракету, а второй создает совершенно тупую. Помните, что даже ванильные «неуправляемые» ракеты, такие как Cannonball, используют LOCK . Необходимо использовать в сочетании с:
        ///time_to_lock (только если искатель LOCK )
        ///seeker_range (только если искатель LOCK )
        ///seeker_fov_deg ( только если искатель LOCK )
        ///max_angular_velocity ( только если искатель LOCK )
        ///DA_archetype материал_библиотека
        /// </summary>
        [Header("Тип ракеты")]
        public SeekerType Seeker;

        /// <summary>
        /// Устанавливает время в секундах, до которого ракета захватит выбранную цель.
        /// </summary>
        [Header("Тип ракеты")]
        public float TimeToLock;

        /// <summary>
        /// Максимальная дальность поиска, независимо от фактической эффективной дальности.
        /// Если цель находится за пределами этого диапазона, ракета не будет сопровождать ее.
        /// </summary>
        [Header("Максимальная дальность поиска, независимо от фактической эффективной дальности. ")]
        public int SeekerRange;

        /// <summary>
        /// Устанавливает поле зрения в градусах, в пределах которого будет отслеживаться ракета.
        /// Это значение отклоняется от оси в градусах.
        /// Например, значение 15 означает, что искатель будет сопровождать цель,
        /// расположенную под углом 15 градусов влево или вправо от его носа.
        /// </summary>
        [Header("Поле зрения в градусах")]
        public int SeekerFovDeg;

        /// <summary>
        /// Определяет максимальную угловую скорость в рад/с (?)
        /// </summary>
        [Header("Максимальная угловая скорость")]
        public float MaxAngularVelocity;

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
        /// Число ракет в боезапасе
        /// </summary>
        [Header("Число ракет в боезапасе")]
        public int AmmoLimit;

        /// <summary>
        /// Если установлено значение true, оружие нарушит круиз,
        /// если нанесет урон. Обычно отсутствует, если не установлено значение true.
        /// </summary>
        [Header("Может ли нарушить круиз")]
        public bool CruiseDisruptor;

        /// <summary>
        /// Урон по корпусу
        /// </summary>
        [Header("Урон по корпусу")]
        public float HullDamage;

        /// <summary>
        /// ((hull_damade / 2) + energy_damage) = урон по щиту
        /// </summary>
        [Header("((hull_damade / 2) + energy_damage) = урон по щиту")]
        public float EnergyDamage;

        /// <summary>
        /// Тип оружия для расчета блокировки разными типами щитов
        /// </summary>
        [Header("Тип оружия для расчета блокировки разными типами щитов")]
        public WeaponTypeStats WeaponType;

        /// <summary>
        /// Импект - эффект попадания (Не следует использовать, если используется Explosion_arch)
        /// </summary>
        [Header("Импект - эффект попадания")]
        public EffectMain MunitionHitEffect;

        /// <summary>
        /// Безопасное время владельца
        /// </summary>
        [Header("Безопасное время владельца")]
        public int OwnerSafeTime;

        /// <summary>
        /// Способность выпадать из трюма при смерти игрока (значения true/false)
        /// </summary>
        [Header("Способность выпадать из трюма при смерти игрока (значения true/false)")]
        public bool Lootable;

    }
}
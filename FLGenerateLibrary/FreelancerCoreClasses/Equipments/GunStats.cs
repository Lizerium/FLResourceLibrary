using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class GunStats
    {
        /// <summary>
        /// Никнейм
        /// </summary>
        [Header("Никнейм")]
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
        /// Устанавливает точку крепления , от которой CMP или 3DB оружия будут прикреплены к точке крепления корабля/солнца.
        /// </summary>
        [Header("Устанавливает точку крепления , от которой CMP или 3DB оружия будут прикреплены к точке крепления корабля/солнца.")]
        public string HPСhild;

        /// <summary>
        /// Количество здоровья у предмета
        /// </summary>
        [Header("Количество здоровья у предмета")]
        public long HitPts;

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
        /// Вес, занимаемый в трюме
        /// </summary>
        [Header("Вес, занимаемый в трюме")]
        public float Volume;

        /// <summary>
        /// "Вес" оборудования, добавляется к корабельному для расчета инерции
        /// </summary>
        [Header("Вес оборудования, добавляется к корабельному для расчета инерции")]
        public float Mass;

        /// <summary>
        /// Тип специального слота (в простонародье класс пухи)
        /// </summary>
        [Header("Тип специального слота (в простонародье класс пухи)")]
        public HpGunType HpGunType;

        /// <summary>
        /// Самоуничтожение оружия при выстреле
        /// </summary>
        [Header("Самоуничтожение оружия при выстреле")]
        public int DamagePerFire;

        /// <summary>
        /// Трата энергии за выстрел
        /// </summary>
        [Header("Трата энергии за выстрел")]
        public float PowerUsage;

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
        public MunitionStats ProjectileArchetype;

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
        /// У турелей все правда. Похоже, это часть незавершенной функции автотурели. NPC будут использовать это как автотурель, если установлено значение true.
        /// </summary>
        [Header("У турелей все правда. Похоже, это часть незавершенной функции автотурели. NPC будут использовать это как автотурель, если установлено значение true.")]
        public bool AutoTurret;

        /// <summary>
        /// Скорость поворота (градусов в секунду)
        /// </summary>
        [Header("Скорость поворота (градусов в секунду)")]
        public int TurnRate;

        /// <summary>
        /// Способность выпадать из трюма при смерти игрока (значения true/false)
        /// </summary>
        [Header("Способность выпадать из трюма при смерти игрока (значения true/false)")]
        public bool Lootable;

        /// <summary>
        /// Дальность видимости модели оружия
        /// </summary>
        [Header("Дальность видимости модели оружия")]
        public List<string> LODRanges;

        /// <summary>
        /// Анимация динамического освещения (отключено в обычном фриле)
        /// </summary>
        [Header("Анимация динамического освещения (отключено в обычном фриле)")]
        public string UseAnimation;

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
        /// ?
        /// </summary>
        [Header("?")]
        public string Obj;

        /// <summary>
        /// Cпособность рассеивания выстрелов, в градусах
        /// </summary>
        [Header("Cпособность рассеивания выстрелов, в градусах")]
        public float DispersionAngle;

        /// <summary>
        /// Замедление
        /// </summary>
        [Header("Замедление")]
        public float LinearDrag;
    }
}
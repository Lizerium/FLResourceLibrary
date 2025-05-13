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
    public class EngineStats : Equipment
    {
        /// <summary>
        /// Иконка в магазине
        /// </summary>
        [Header("Иконка в магазине")]
        public GameObject ItemIcon;

        /// <summary>
        /// Скорость поворота
        /// </summary>
        [Header("Скорость поворота")]
        public float TurnMove = 20f;

        /// <summary>
        /// Скорость возврата в нормальное состояние
        /// </summary>
        [Header("Скорость возврата в нормальное состояние")]
        public float TurnNormalMove = 40f;

        /// <summary>
        /// Максимальная скорость корабля
        /// </summary>
        [Header("Максимальная скорость корабля")]
        public float SpeedMax = 75f;

        /// <summary>
        /// Актуальная сокрость
        /// </summary>
        [Header("Актуальная сокрость")]
        public float SpeedNow = .0f;

        /// <summary>
        /// Регулятор чувствительности отклонения мыши
        /// </summary>
        [Header("Регулятор чувствительности отклонения мыши")]
        [Range(0, 100f)]
        public float MouseSensitivityKef = 20.0f;

        /// <summary>
        /// Угол крена судна 
        /// </summary>
        [Header("Угол крена судна")]
        [Range(0, 360)]
        public int AngleRoll = 15;

        /// <summary>
        /// Коэфициент набора скорости обычного двигателя
        /// </summary>
        [Header("Коэфициент набора скорости обычного двигателя")]
        public float SpeedKefNow = 2f;



        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Громкость звука
        /// </summary>
        [Header("Громкость звука")]
        public float Volume;

        /// <summary>
        /// Масса двигателя 
        /// </summary>
        [Header("Масса двигателя")]
        public float Mass;

        /// <summary>
        /// Тяга двигателя (делим на 600 aи получаем скорость в м/с: 48000/600 = 80 м/с)
        /// </summary>
        [Header("Тяга двигателя")]
        public int MaxForce;

        /// <summary>
        /// Сила замедления
        /// </summary>
        [Header("Сила замедления")]
        public float LinearDrag;

        /// <summary>
        /// Количество мощности, которую двигатель использует от силовой установки
        /// </summary>
        [Header("Количество мощности, которую двигатель использует от силовой установки")]
        public float PowerUsage;

        /// <summary>
        /// Определяет, насколько быстро вы можете двигаться назад (0-1)
        /// </summary>
        [Header("Определяет, насколько быстро вы можете двигаться назад")]
        public float ReverseFraction;

        /// <summary>
        /// Устанавливает, сколько секунд потребуется для зарядки в режиме круиза.
        /// </summary>
        [Header("Устанавливает, сколько секунд потребуется для зарядки в режиме круиза")]
        public float CruiseChargeTime;

        /// <summary>
        /// Когда вы находитесь в круизном режиме, это количество энергии, которое будет расходоваться в секунду.
        /// Если ваша электростанция не может обеспечить такое количество энергии, 
        /// вы соответствующим образом замедлитесь, как только буфер опустеет.
        /// </summary>
        [Header("Когда вы находитесь в круизном режиме, это количество энергии, которое будет расходоваться в секунду.")]
        public float CruisePowerUsage;

        /// <summary>
        /// Отсылает к звуковому эффекту, который издает ваш двигатель во время обычного полета.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который издает ваш двигатель во время обычного полета.")]
        public SoundBase CharacterLoopSound;

        /// <summary>
        /// В Freelancer звуки повышаются/понижаются, поэтому они не всегда звучат одинаково. Эти два значения, вероятно, являются нижней и верхней границей этого искажения.
        /// </summary>
        [Header("Нижняя и верхняя граница искажения звука обычного двигателя")]
        public Vector2 CharacterPitchRange;

        /// <summary>
        /// Ссылается на звуковой эффект. Устанавливает звук, который постоянно издает двигатель.
        /// </summary>
        [Header("Устанавливает звук, который постоянно издает двигатель.")]
        public SoundBase RumbleSound;

        /// <summary>
        /// В Freelancer звуки усиливаются/приглушаются, поэтому их громкость не всегда одинакова. Эти два значения, вероятно, являются нижней и верхней границей этого показателя.
        /// </summary>
        [Header("Нижняя и верхняя граница усиливания/приглушения звука двигателя")]
        public Vector2 RumbleAttenRange;

        /// <summary>
        /// В Freelancer звуки повышаются/понижаются, поэтому они не всегда звучат одинаково. Эти два значения, вероятно, являются нижней и верхней границей этого искажения.
        /// </summary>
        [Header("Нижняя и верхняя граница искажения звука обычного двигателя")]
        public Vector2 RumblePitchRange;

        /// <summary>
        /// Можно ли уничтожить (false - да, true - нет)
        /// </summary>
        [Header("Можно ли уничтожить")]
        public bool Indestructible;

        /// <summary>
        /// В Freelancer звуки усиливаются/приглушаются, поэтому они не всегда имеют одинаковую громкость. Внутри external_sound_cone звук имеет другую громкость, чем в Inside_sound_cone. Если вы не находитесь ни в одном из них, вы ничего не услышите.
        /// </summary>
        [Header("Внешнее конусное затухание")]
        public int OutsideСoneAttenuation;

        /// <summary>
        /// В Freelancer звуки усиливаются/приглушаются, поэтому они не всегда имеют одинаковую громкость. Внутри external_sound_cone звук имеет другую громкость, чем в Inside_sound_cone. Если вы не находитесь ни в одном из них, вы ничего не услышите.
        /// </summary>
        [Header("Внутреннее конусное затухание")]
        public int InsideSoundCone;

        /// <summary>
        /// В Freelancer звуки усиливаются/приглушаются, поэтому они не всегда имеют одинаковую громкость. Внутри external_sound_cone звук имеет другую громкость, чем в Inside_sound_cone. Если вы не находитесь ни в одном из них, вы ничего не услышите.
        /// </summary>
        [Header("Внешний звуковой конус")]
        public int OutsideSoundCone;

        /// <summary>
        /// Максимальная мощность двигателя
        /// </summary>
        [Header("Максимальная мощность двигателя")]
        public float СruiseSpeed = 500.0f;

        /// <summary>
        /// Эффект двигателя (это модифицированные эффекты пламени)
        /// </summary>
        [Header("Эффект двигателя (модифицированные эффекты пламени)")]
        public EffectMain FlameEffect;

        /// <summary>
        /// Модифицированный круизный эффект
        /// </summary>
        [Header("Модифицированный круизный эффект")]
        public EffectMain TrailEffect;

        /// <summary>
        /// Круизный эффект и эффект тропы двигателя
        /// </summary>
        [Header("Круизный эффект и эффект тропы двигателя")]
        public EffectMain TrailEffectPlayer;

        /// <summary>
        /// Вы слышите этот звук, когда возобновляете работу после остановки двигателя.
        /// </summary>
        [Header("Вы слышите этот звук, когда возобновляете работу после остановки двигателя")]
        public SoundBase CharacterStartSound;

        /// <summary>
        /// Отсылает к звуковому эффекту, который воспроизводится при нажатии кнопки выключения двигателя.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который воспроизводится при нажатии кнопки выключения двигателя.")]
        public SoundBase EngineKillSound;

        /// <summary>
        /// Отсылает к звуковому эффекту, который воспроизводится при переходе в круизный режим.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который воспроизводится при переходе в круизный режим.")]
        public SoundBase CruiseStartSound;

        /// <summary>
        /// Отсылает к звуковому эффекту, который воспроизводится, когда вы находитесь в круизном режиме.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который воспроизводится, когда вы находитесь в круизном режиме.")]
        public SoundBase CruiseLoopSound;

        /// <summary>
        /// Отсылает к звуковому эффекту, который воспроизводится при выходе из круизного режима.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который воспроизводится при выходе из круизного режима.")]
        public SoundBase CruiseStopSound;

        /// <summary>
        /// Отсылает к звуковому эффекту, который воспроизводится при нарушении режима круиза.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который воспроизводится при нарушении режима круиза.")]
        public SoundBase CruiseDisruptSound;

        /// <summary>
        /// Отсылает к звуковому эффекту, который воспроизводится при нарушении режима круиза боем.
        /// </summary>
        [Header("Отсылает к звуковому эффекту, который воспроизводится при нарушении режима круиза боем.")]
        public SoundBase CruiseBackfireSound;

        /// <summary>
        /// Эффект срыва круиза
        /// </summary>
        [Header("Эффект срыва круиза")]
        public EffectMain CruiseDisruptEffect;

        /// <summary>
        /// Используемое здесь имя группы может быть свободно 
        /// выбрано и должно совпадать с именем кораблей, 
        /// на которых может быть установлена эта пушка
        /// Строка группы установок не является обязательной, 
        /// все корабли и орудия, не указанные в группе, 
        /// будут просто рассматриваться как одна большая группа, 
        /// на которую нельзя устанавливать ничего из других групп, 
        /// и наоборот.
        /// </summary>
        [Header("Имя группы")]
        public HpMountGroup HpMountGroup = HpMountGroup.NONE;

        /// <summary>
        /// Адрес до модельки 3db в оригинале
        /// </summary>
        [Header("Адрес до модельки 3db в оригинале")]
        public string DAArchetype;

        /// <summary>
        /// Адрес до материала .mat в оригинале
        /// </summary>
        [Header("Адрес до материала .mat в оригинале")]
        public string MaterialLibrary;

        /// <summary>
        /// Дистанции LOD
        /// </summary>
        [Header("Дистанции LOD")]
        public List<string> LODRanges;

        /// <summary>
        /// Эффект взрыва - вспышка с осколками
        /// </summary>
        [Header("Эффект взрыва - вспышка с осколками")]
        public ExplosionStats ExplosionArch;

        /// <summary>
        /// Можно ли притянуть захватом
        /// </summary>
        [Header("Можно ли притянуть захватом")]
        public bool Lootable = true;

        /// <summary>
        /// Скорость для GUI в формате числа Int
        /// </summary>
        public string SpeedGUI => ((int)Math.Ceiling(Math.Round(SpeedNow, 1))).ToString();
    }
}
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
    public class ExplosionStats
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Время жизни
        /// </summary>
        public Vector2 Lifetime;

        /// <summary>
        /// Тип процесса
        /// </summary>
        public ExpProcessType Process = ExpProcessType.none;

        /// <summary>
        /// Прикрепленный эффект
        /// </summary>
        public EffectExplosionSt Effect;

        /// <summary>
        /// Описание характеристик частиц
        /// </summary>
        public List<DebrisTypeSt> DebrisType;

        /// <summary>
        /// Время запуска
        /// </summary>
        public float InnardsDebrisStartTime;

        /// <summary>
        /// Скорость вылетаемых частей
        /// </summary>
        public int DebrisImpulse;

        /// <summary>
        /// Ограничение на число [CollisionGroup]
        /// </summary>
        public int NumChildPieces;

        /// <summary>
        /// Число
        /// </summary>
        public int InnardsDebrisNum;

        /// <summary>
        /// Радиус вылета (т.е. от  0 до N)
        /// </summary>
        public int InnardsDebrisRadius;

        /// <summary>
        /// Cсылка на модель
        /// </summary>
        public List<SimpleStats> InnardsDebrisObject;

        /// <summary>
        /// Радиус сферы, в которой будет наноситься урон и импульс. 
        /// Помните, что радиус не влияет на данный урон/импульс, 
        /// поскольку полный определенный урон/импульс будет дан 
        /// независимо от того, находится ли цель на 5% внутри сферы или на 100%.
        /// </summary>
        public int Radius;

        /// <summary>
        /// Урон по корпусу
        /// </summary>
        public float HullDamage;

        /// <summary>
        /// Урон по щиту
        /// </summary>
        public int EnerhyDamage;

        /// <summary>
        /// Неизвестные фактические эффекты. Может влиять на поведение NPC (похоже на выносливость?)
        /// </summary>
        public int Strength;

        /// <summary>
        /// Все объекты в радиусе будут отталкиваться от центра взрыва указанной силой. 
        /// Возможно, для эффективности этого значения необходимо установить чрезвычайно высокое значение.
        /// </summary>
        public int Impulse;

        /// <summary>
        /// Он добавляет «critical_hit = процент, множитель» в разделы [Взрыв]
        /// (поэтому он не будет работать с оружием).
        /// Работает только при попадании в корпус,
        /// а не в щит. См. Criticalhit.cpp для установки.
        /// </summary>
        public CriticalHitSt CriticalHit;
    }
}
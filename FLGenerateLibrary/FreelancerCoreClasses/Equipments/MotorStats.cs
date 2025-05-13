using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class MotorStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Определяет, как долго двигатель будет ускоряться со скоростью, заданной параметром ускорения .
        /// </summary>
        [Header("Определяет, как долго двигатель будет ускоряться со скоростью, заданной параметром ускорения .")]
        public float Lifetime;

        /// <summary>
        /// Определяет ускорение, придаваемое двигателем снаряду, скорее всего ракете.
        /// Можно ввести отрицательное значение, чтобы заставить снаряд замедлиться.
        /// Ускорение выражается в м/с2
        /// </summary>
        [Header("Ускорение")]
        public float Accel;

        /// <summary>
        /// Определяет время в секундах, до которого двигатель начнет ускоряться.
        /// Таким образом, полное время ускорения можно рассчитать как задержку + срок службы.
        /// </summary>
        [Header("Задержка ускорения")]
        public float Delay;
    }
}
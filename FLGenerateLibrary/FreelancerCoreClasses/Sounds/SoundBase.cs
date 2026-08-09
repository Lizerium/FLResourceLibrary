/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 августа 2026 15:30:52
 * Version: 1.0.353
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class SoundBase
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Звук
        /// </summary>
        public AudioClip Clip;

        /// <summary>
        /// Радиус слышимости звука
        /// </summary>
        public Vector2 Range;

        /// <summary>
        /// Затухание. Диапазон: от -infty до 0. Уменьшает громкость звука.
        /// </summary>
        [Range(-int.MaxValue, 0)]
        public int Attenuation;

        /// <summary>
        /// Тип звука
        /// </summary>
        public SoundType Type = SoundType.none;
    }
}
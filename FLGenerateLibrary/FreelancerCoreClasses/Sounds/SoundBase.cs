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
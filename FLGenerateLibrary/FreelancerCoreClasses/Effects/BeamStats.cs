using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class BeamStats
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Длина головной части снаряда
        /// </summary>
        [Header("длина головной части снаряда")]
        public int TipLength;

        /// <summary>
        /// Длина хвоста снаряда
        /// </summary>
        [Header("длина хвоста снаряда")]
        public int TailLength;

        /// <summary>
        /// Ширина головной части снаряда
        /// </summary>
        [Header("ширина головной части снаряда")]
        public float HeadWidth;

        /// <summary>
        /// Размер ядра снаряда
        /// </summary>
        [Header("размер ядра снаряда")]
        public float CoreWidth;

        /// <summary>
        /// Цвет головной части
        /// </summary>
        [Header("Цвет головной части")]
        public Color32 TipColor;

        /// <summary>
        /// Цвет ядра снаряда
        /// </summary>
        [Header("Цвет ядра снаряда")]
        public Color32 CoreColor;

        /// <summary>
        /// Цвет ?
        /// </summary>
        [Header("Цвет ?")]
        public Color32 OutterColor;

        /// <summary>
        /// Цвет хвоста снаряда
        /// </summary>
        [Header("Цвет хвоста снаряда")]
        public Color32 TailColor;

        /// <summary>
        /// Яркость головной части снаряда
        /// </summary>
        [Header("яркость головной части снаряда")]
        public float HeadBrightness;

        /// <summary>
        /// Яркость хвоста снаряда
        /// </summary>
        [Header("яркость хвоста снаряда")]
        public float TrailBrightness;

        /// <summary>
        /// Форма головной части снаряда либо BALL либо STAR
        /// </summary>
        [Header("форма головной части снаряда")]
        public HeadTextureType HeadTexture;

        /// <summary>
        /// Форма хвостовой части снаряда либо THIN либо WIDE
        /// </summary>
        [Header("форма хвостовой части снаряда")]
        public TrailTextureType TrailTexture;

        /// <summary>
        /// Размер вспышки выстрела
        /// </summary>
        [Header("размер вспышки выстрела")]
        public int FlashSize;

        /// <summary>
        /// Длина второго ядра снаряда
        /// </summary>
        [Header("Длина второго ядра снаряда")]
        public int CoreLength;

        /// <summary>
        /// Ширина второго ядра снаряда
        /// </summary>
        [Header("Ширина второго ядра снаряда")]
        public float SecCoreWidth;

        /// <summary>
        /// Второй основной цвет
        /// </summary>
        [Header("Второй основной цвет")]
        public Color32 SecCoreColor;

        /// <summary>
        /// Второй внешний цвет
        /// </summary>
        [Header("Второй внешний цвет")]
        public Color32 SecOutterColor;
    }
}
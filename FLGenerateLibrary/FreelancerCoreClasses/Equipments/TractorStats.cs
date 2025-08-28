/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:08:13
 * Version: 1.0.3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class TractorStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор частицы
        /// </summary>
        [Header("Уникальный идентификатор частицы")]
        public string Nickname;

        /// <summary>
        /// Вес в грузовом отсеке
        /// </summary>
        [Header("Вес в грузовом отсеке")]
        public float Volume;

        /// <summary>
        /// Единица "веса" частицы(для расчета инерции), энергетическому оружию всегда 1
        /// </summary>
        [Header("Единица веса частицы(для расчета инерции), энергетическому оружию всегда 1")]
        public float Mass;

        /// <summary>
        /// Материал
        /// </summary>
        [Header("Материал")]
        public string MaterialLibrary;

        /// <summary>
        /// Адрес до модельки 3db в оригинале
        /// </summary>
        [Header("Адрес до модельки 3db в оригинале")]
        public string DAArchetype;

        /// <summary>
        /// Максимальная длина притягивающего луча.
        /// </summary>
        [Header("Максимальная длина притягивающего луча.")]
        public int MaxLength;

        /// <summary>
        /// Насколько быстро вылетает притягивающий луч.
        /// </summary>
        [Header("Насколько быстро вылетает притягивающий луч.")]
        public int ReachSpeed;

        /// <summary>
        /// Цвет луча
        /// </summary>
        [Header("Цвет луча")]
        public Color32 Color;

        /// <summary>
        /// Какой эффект отображается при включении.
        /// </summary>
        [Header("Какой эффект отображается при включении.")]
        public EffectMain OperatingEffect;

        /// <summary>
        /// Какой звук воспроизводится, когда все предметы втянуты.
        /// </summary>
        [Header("Какой звук воспроизводится, когда все предметы втянуты.")]
        public SoundBase TractorCompleteSnd;

        /// <summary>
        /// Можно ли притянуть захватом
        /// </summary>
        [Header("Можно ли притянуть захватом")]
        public bool Lootable = true;
    }
}
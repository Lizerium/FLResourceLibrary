/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 июля 2026 15:44:43
 * Version: 1.0.342
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class InternalFXStats
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Какой звук используется эффектом. 
        /// </summary>
        [Header("Какой звук используется эффектом.")]
        public SoundBase UseSound;

        /// <summary>
        /// Какая анимация используется эффектом. 
        /// </summary>
        [Header(" Какая анимация используется эффектом.")]
        public EffectMain UseAnimation;
    }
}
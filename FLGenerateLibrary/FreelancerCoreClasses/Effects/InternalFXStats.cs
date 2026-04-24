/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:51:51
 * Version: 1.0.244
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
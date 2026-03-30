/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:20:52
 * Version: 1.0.217
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class AttachedFXStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Эффект 
        /// </summary>
        [Header("Эффект")]
        public EffectMain Particles;

        /// <summary>
        /// Может ли эффект меняться в зависимости от скорости эммитера?
        /// </summary>
        [Header("Может ли эффект меняться в зависимости от скорости эммитера?")]
        public bool UseThrottle;
    }
}
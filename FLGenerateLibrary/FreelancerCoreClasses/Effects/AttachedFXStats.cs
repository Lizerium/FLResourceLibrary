/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 февраля 2026 06:52:10
 * Version: 1.0.161
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
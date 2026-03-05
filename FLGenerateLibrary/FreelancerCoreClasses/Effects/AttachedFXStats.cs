/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 марта 2026 14:59:19
 * Version: 1.0.192
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
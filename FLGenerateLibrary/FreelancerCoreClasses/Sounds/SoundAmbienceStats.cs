/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 июля 2026 08:47:03
 * Version: 1.0.317
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class SoundAmbienceStats : SoundBase
    {
        /// <summary>
        /// Это наблюдается только в файлах оружия и влияет на изменение 
        /// высоты тона в звуковых файлах через случайные промежутки времени, 
        /// чтобы звуки не были «одинаковыми». Отрицательные значения изменяют 
        /// высоту звука в более низком диапазоне, а положительные значения — 
        /// в более высоком. Насколько я знаю, это делается в полутонах. 
        /// например, -12 создает нижний октавный диапазон.
        /// </summary>
        public int CrvPitch = 0;
    }
}
/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 мая 2025 15:25:18
 * Version: 1.0.1
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
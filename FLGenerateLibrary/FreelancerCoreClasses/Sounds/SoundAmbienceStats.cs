/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:35:07
 * Version: 1.0.5
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
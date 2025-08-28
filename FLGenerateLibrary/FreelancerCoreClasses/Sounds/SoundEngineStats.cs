﻿/*
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
    public class SoundEngineStats : SoundBase
    {
        /// <summary>
        /// Определяет, всегда ли файл воспроизводится через стереоканалы 
        /// и игнорирует 3D-движок. Обычно это используется только 
        /// для речевых файлов и файлов пользовательского интерфейса.
        /// </summary>
        public bool Is2d = false;

        /// <summary>
        /// Можно ли изменить высоту звука. Например, эффект Доплера при пролетах.
        /// </summary>
        public bool PitchBendable;
    }
}
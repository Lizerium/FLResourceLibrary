/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 мая 2026 10:36:51
 * Version: 1.0.265
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class SoundMusicStats : SoundBase
    {
        /// <summary>
        /// Используется только в длинных музыкальных треках 
        /// или длинных речевых файлах. Значение True будет 
        /// обеспечивать постоянную потоковую передачу файла, 
        /// а не кэширование всего файла из соображений производительности. 
        /// Эту функцию следует включать только для больших файлов PCM, 
        /// поскольку файлы MP3, как правило, достаточно малы.
        /// </summary>
        public bool Streamer = false;
    }
}
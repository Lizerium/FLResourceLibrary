/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:14:36
 * Version: 1.0.34
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
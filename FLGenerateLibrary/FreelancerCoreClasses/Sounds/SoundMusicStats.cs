/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 марта 2026 06:52:23
 * Version: 1.0.198
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
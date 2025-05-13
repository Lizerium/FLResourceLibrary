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
    public class CloakinFX
    {
        public Color BaseColor = Color.white;
        public Vector2 Tiling = new Vector2(1f, 1f);
        public Vector2 Offset = new Vector2(0f, 0f);
        [Range(0f, 1f)]
        public float Dissolve = 0f;
        public float NoiseScale = 50;
        public Vector2 NoiseUVSpeed = new Vector2(0, 0);
        [Range(0f, 1f)]
        public float EdgeWith = 0.05f;
        public Color EdgeColor = Color.white;
        public float EdgeColorIntensity = 1f;
    }
}
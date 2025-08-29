/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2025 06:52:13
 * Version: 1.0.4
 */

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class Item
    {
        public int Price = 10000;
        public Rarity Rarity = Rarity.Common;
        public static Color GetMatchingColor(Item item)
        {
            Color newColor;

            switch (item.Rarity)
            {
                case Rarity.Trash:
                    newColor = Color.gray;
                    break;
                case Rarity.Common:
                    newColor = Color.white;
                    break;
                case Rarity.Uncommon:
                    newColor = Color.green;
                    break;
                case Rarity.Rare:
                    newColor = Color.blue;
                    break;
                case Rarity.Unique:
                    newColor = Color.cyan;
                    break;
                case Rarity.Alien:
                    newColor = Color.magenta;
                    break;
                case Rarity.Solar:
                    newColor = Color.red;
                    break;
                default:
                    newColor = Color.white;
                    break;
            }

            return newColor;
        }
    }
}
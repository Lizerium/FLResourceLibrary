using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class ArmorStats : Equipment
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Это то, что ваша броня, умноженная на 1, означает отсутствие изменения брони, 0,9 и ниже уменьшает вашу броню, а 1,1 и выше увеличивает вашу броню.
        /// </summary>
        [Header("Коэфициент увеличения уменьшения брони корабля")]
        public float HitPtsScale;

        /// <summary>
        /// Категория предмета
        /// </summary>
        [Header("Категория предмета")]
        public CategoryType Category;

        /// <summary>
        /// Точка монтирования
        /// </summary>
        [Header("Точка монтирования")]
        public string HPChild;

        /// <summary>
        /// Материал
        /// </summary>
        [Header("Материал")]
        public string MaterialLibrary;

        /// <summary>
        /// Модель
        /// </summary>
        [Header("Модель")]
        public string DAArchetype;

        /// <summary>
        /// Вес, занимаемый в трюме
        /// </summary>
        [Header("Вес, занимаемый в трюме")]
        public float Volume;

        /// <summary>
        /// Масса
        /// </summary>
        [Header("Масса")]
        public int Mass;

        /// <summary>
        /// Выпадает при взрыве корабля, true = да
        /// </summary>
        [Header("Выпадает при взрыве корабля, true = да")]
        public bool Lootable = true;

        /// <summary>
        /// Эффект взрыва
        /// </summary>
        [Header("Эффект взрыва")]
        public ExplosionStats ExplosionArch;

        /// <summary>
        /// Линейный противовес. Т.е. это как на круиз встаешь на КЭ и тебя останавливает потихоньку
        /// </summary>
        [Header("Линейный противовес")]
        public float LinearDrag;
    }
}
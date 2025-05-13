using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FLGenerateLibrary
{
    public class DebrisStats
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Header("Уникальный идентификатор")]
        public string Nickname;

        /// <summary>
        /// Метод взрыва
        /// </summary>
        [Header("Метод взрыва")]
        public DeathMethod DeathMethod;

        /// <summary>
        /// Время жизни
        /// </summary>
        [Header("Время жизни")]
        public Vector2 Lifetime;

        /// <summary>
        /// Линейный противовес. Т.е. это как на круиз встаешь на КЭ и тебя останавливает потихоньку
        /// </summary>
        [Header("Линейный противовес")]
        public float LinearDrag;

        /// <summary>
        /// Вращение по осям X Y Z.
        /// </summary>
        [Header("Вращение по осям X Y Z")]
        public Vector3 AngularDrag;

        /// <summary>
        /// Эффект трейла огонька
        /// </summary>
        [Header("Эффект трейла огонька")]
        public EffectMain Trail;

        /// <summary>
        /// Cсылка на другой взрыв
        /// </summary>
        [Header("Cсылка на другой взрыв")]
        public ExplosionStats Explosion;

        /// <summary>
        /// Инерция вращения
        /// </summary>
        [Header("Инерция вращения")]
        public Vector3 RotationInertia;
    }
}
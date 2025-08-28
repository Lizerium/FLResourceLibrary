/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:08:13
 * Version: 1.0.3
 */

using UnityEngine.VFX;

namespace FLGenerateLibrary
{
    public class EffectMain
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Тип эффекта
        /// </summary>
        public ExplosionEffectType EffectType;

        /// <summary>
        /// Эффект
        /// </summary>
        public VisualEffect VisEffect;

        /// <summary>
        /// Звук
        /// </summary>
        public SoundStats SndEffect;

        /// <summary>
        /// Эффект освещения объектов вокруг (в light_anim)
        /// </summary>
        public VisualEffect LgtEffect;

        /// <summary>
        /// Увеличение шарика света в зависимости от расстояния
        /// </summary>
        public int LgtRangeScale;

        /// <summary>
        /// Размер шарика света
        /// </summary>
        public int LgtRadius;

        /// <summary>
        /// Эффект двигателя
        /// </summary>
        public VisualEffect VisGeneric;

        /// <summary>
        /// Эффект пули оружия
        /// </summary>
        public BeamStats VisBeam;
    }
}
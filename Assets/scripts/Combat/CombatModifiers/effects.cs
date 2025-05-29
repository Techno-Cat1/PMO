using UnityEngine;

namespace CoreCombat
{
    public enum MoveTypes
    {
        Aura,               // Aura and Pulse Moves
        Ball,               // Ball and Bomb Moves
        Biting,
        Buddy,
        Dance,
        Explosive,
        Field,
        FinalSmash,
        MoveMastery,        // Fighting Styles in Pokemon Legends Arceus
        Multistrike,
        OHKO,
        Powder,             // Powder and Spore Moves
        Slicing,
        SoundBased,
        Wind,
        GMax,
        MaxMove,
        ZMove
    }

    public enum Range
    {
        User,
        Facing_Opponent,
        Adjacent_Allies,
        Adjacent_Opponent,
        Allies_Team,
        Opponent_Team,
        All_Adjacent,
        All_But_User,
        All,
        Choosen
    }


    public class EffectResult
    {
        public float RawValue;                   // General DMG
        public float ElementalValue;             // Elemental Damage
        public bool Success;
        public int duration;
        public Stats StatsChange;
    }

    public interface IStatusEffect
    {
        TypeElement Element { get; }
        bool IsVolatile { get; }
        EffectResult OnApply(BattleContext ctx);
        EffectResult OnTick(BattleContext ctx);
        EffectResult OnExpire(BattleContext ctx);
    }

}
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

    public class EffectResult
    {
        public float RawValue;              // General DMG
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

    public class Burn : IStatusEffect
    {
        public TypeElement Element => TypeElement.Fire;
        public bool IsVolatile => false;

        public EffectResult OnApply(BattleContext ctx)
        {
            Debug.Log("Burn applied!");
            return new EffectResult
            {
                RawValue = 0f,
                ElementalValue = 1f,
                Success = true,
                duration = -1,
                StatsChange = new Stats
                {
                    MaxHp = 0f,
                    Atk = 0.5f,
                    Def = 0f,
                    SpAtk = 0f,
                    SpDef = 0f,
                    Speed = 0f
                }
            };
        }

        public EffectResult OnTick(BattleContext ctx)
        {
            Debug.Log("Burn tick!");
            return new EffectResult
            {
                RawValue = 1f / 16f,
                ElementalValue = 1f,
                Success = true,
                duration = -1,
                StatsChange = null
            };
        }

        public EffectResult OnExpire(BattleContext ctx)
        {
            Debug.Log("Burn expired!");
            return new EffectResult
            {
                RawValue = 0f,
                ElementalValue = 1f,
                Success = true,
                duration = 0,
                StatsChange = new Stats
                {
                    MaxHp = 0f,
                    Atk = 2f, 
                    Def = 0f,
                    SpAtk = 0f,
                    SpDef = 0f,
                    Speed = 0f
                }
            };
        }
    }

}
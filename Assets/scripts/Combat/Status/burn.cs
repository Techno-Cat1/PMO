using UnityEngine;

namespace CoreCombat
{
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
                    Atk = 1f / 2f,
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
                StatsChange = Stats.Zero
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
                    Atk = 2f,
                }
            };
        }
    }
}
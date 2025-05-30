using UnityEngine;

namespace CoreCombat
{


    public class EffectResult
    {
        public float RawValue;                      // Normal DMG
        public float ElementalValue;                // ElementalDamage
        public bool Success;
        public int duration;
        public Stats StatsChange;

        public static readonly EffectResult Zero = new EffectResult
        {
            RawValue = 0f,
            ElementalValue = 0f,
            Success = false,
            duration = 0,
            StatsChange = Stats.Zero
        };
    }

    public static class TypeChart
    {
        private static readonly Dictionary<TypeElement, Dictionary<TypeElement, float>> effectiveness =
            new()
            {
            { TypeElement.Normal, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f / 2f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 0f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Fighting, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 2f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f / 2f },
                    { TypeElement.Poison, 1f / 2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1f / 2f },
                    { TypeElement.Ghost, 0f },
                    { TypeElement.Steel, 2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f / 2f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 2f },
                    { TypeElement.Fairy, 1f / 2f }
            }
            },
            { TypeElement.Flying, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 2f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f / 2f },
                    { TypeElement.Bug, 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f / 2f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Poison, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f / 2f },
                    { TypeElement.Ground, 1f / 2f },
                    { TypeElement.Rock, 1f / 2f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f / 2f },
                    { TypeElement.Steel, 0f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 2f }
            }
            },
            { TypeElement.Ground, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 0f },
                    { TypeElement.Poison, 2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1f / 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 2f },
                    { TypeElement.Fire, 2f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f / 2f },
                    { TypeElement.Electric, 2f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Rock, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f / 2f },
                    { TypeElement.Flying, 2f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f / 2f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 2f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 2f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Bug, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f / 2f },
                    { TypeElement.Flying, 1f / 2f },
                    { TypeElement.Poison, 1f / 2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f / 2f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f / 2f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 2f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 2f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Ghost, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 0f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 2f },
                    { TypeElement.Steel, 1f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 2f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f / 2f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Steel, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f / 2f },
                    { TypeElement.Water, 1f / 2f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f / 2f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 2f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 2f }
            }
            },
            { TypeElement.Fire, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f / 2f },
                    { TypeElement.Bug, 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 2f },
                    { TypeElement.Fire, 1f / 2f },
                    { TypeElement.Water, 1f / 2f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 2f },
                    { TypeElement.Dragon, 1f / 2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Water, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 2f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f },
                    { TypeElement.Fire, 2f },
                    { TypeElement.Water, 1f / 2f },
                    { TypeElement.Grass, 1f / 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f / 2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Grass, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f / 2f },
                    { TypeElement.Poison, 1f / 2f },
                    { TypeElement.Ground, 2f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1f / 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f / 2f },
                    { TypeElement.Water, 2f },
                    { TypeElement.Grass, 1f / 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f / 2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Electric, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 2f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 0f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 2f },
                    { TypeElement.Grass, 1f / 2f },
                    { TypeElement.Electric, 1f / 2f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f / 2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Psychic, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 2f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f / 2f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 0f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Ice, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 2f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 2f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f / 2f },
                    { TypeElement.Water, 1f / 2f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f / 2f },
                    { TypeElement.Dragon, 2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Dragon, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 0f }
            }
            },
            { TypeElement.Dark, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f / 2f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 2f },
                    { TypeElement.Steel, 1f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 2f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 1f / 2f },
                    { TypeElement.Fairy, 1f / 2f }
            }
            },
            { TypeElement.Fairy, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 2f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f / 2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1f / 2f },
                    { TypeElement.Fire, 1f / 2f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 2f },
                    { TypeElement.Dark, 2f },
                    { TypeElement.Fairy, 1f }
            }
            }
            };

        public static float GetEffectiveness(TypeElement attackingType, TypeElement defendingType)
        {
            // Si l'attaque est dans le dictionnaire
            if (effectiveness.TryGetValue(attackingType, out var innerDict))
            {
                // Si la défense est dans le sous-dictionnaire
                if (innerDict.TryGetValue(defendingType, out float multiplier))
                {
                    return multiplier;
                }
            }

            // Si aucune info spécifique : neutre
            return 1f;
        }
    }

    public class BattleContext
    {
        public Pokemon[] TeamA;
        public Pokemon[] TeamB;

        public FieldEffectManager FieldManager;     // terrain, meteo, room, etc.
        public TurnInfo CurrentTurn;                // Who's turn is it?
        public CombatLog History;                   // logs
        public TargetingContext Targeting;          // Self Explanatory
        public TempFlags Flags;                     // bools of turns
        public Random Rng;                          // custom RNG
    }

    public class Terrain : IFieldEffect
    {
        public string Name => "";
        public int Priority => 0;
        public int duration = 0;
        public FieldCategory FieldType => FieldCategory.Terrain;
        EffectResult OnApply(BattleContext ctx)
        {
            foreach (Terrain T in ctx.Terrains)
            {
                if (T.Priority > this.Priority)
                {
                    ctx.Cancelled = true;
                    return EffectResult.Zero;
                } else if (T.Priority == this.Priority && )
            }
        }

        EffectResult OnTick(BattleContext ctx);
        EffectResult OnExpire(BattleContext ctx);
    }

    public class Pokemon
    {
        public string Name;
        public int CurrentHP;
        public Stats BaseStats = new Stats();
    }
}
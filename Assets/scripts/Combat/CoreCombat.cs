using System.Collections.Generic;

namespace CoreCombat
{
    public enum TypeElement
    {
        Normal,
        Fighting,
        Flying,
        Poison,
        Ground,
        Rock,
        Bug,
        Ghost,
        Steel,
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Ice,
        Dragon,
        Dark,
        Fairy
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
                    { TypeElement.Rock, 1/2f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 0f },
                    { TypeElement.Steel, 1/2f },
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
                    { TypeElement.Flying, 1/2f },
                    { TypeElement.Poison, 1/2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1/2f },
                    { TypeElement.Ghost, 0f },
                    { TypeElement.Steel, 2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1/2f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1f },
                    { TypeElement.Dark, 2f },
                    { TypeElement.Fairy, 1/2f }
            }
            },
            { TypeElement.Flying, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 2f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1/2f },
                    { TypeElement.Bug, 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1/2f },
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
                    { TypeElement.Poison, 1/2f },
                    { TypeElement.Ground, 1/2f },
                    { TypeElement.Rock, 1/2f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1/2f },
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
                    { TypeElement.Bug, 1/2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 2f },
                    { TypeElement.Fire, 2f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1/2f },
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
                    { TypeElement.Fighting, 1/2f },
                    { TypeElement.Flying, 2f },
                    { TypeElement.Poison, 1f },
                    { TypeElement.Ground, 1/2f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1/2f },
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
                    { TypeElement.Fighting, 1/2f },
                    { TypeElement.Flying, 1/2f },
                    { TypeElement.Poison, 1/2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1/2f },
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1/2f },
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
                    { TypeElement.Dark, 1/2f },
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
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1/2f },
                    { TypeElement.Water, 1/2f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1/2f },
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
                    { TypeElement.Rock, 1/2f },
                    { TypeElement.Bug, 2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 2f },
                    { TypeElement.Fire, 1/2f },
                    { TypeElement.Water, 1/2f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 2f },
                    { TypeElement.Dragon, 1/2f },
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
                    { TypeElement.Water, 1/2f },
                    { TypeElement.Grass, 1/2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1/2f },
                    { TypeElement.Dark, 1f },
                    { TypeElement.Fairy, 1f }
            }
            },
            { TypeElement.Grass, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 1f },
                    { TypeElement.Flying, 1/2f },
                    { TypeElement.Poison, 1/2f },
                    { TypeElement.Ground, 2f },
                    { TypeElement.Rock, 2f },
                    { TypeElement.Bug, 1/2f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1/2f },
                    { TypeElement.Water, 2f },
                    { TypeElement.Grass, 1/2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1/2f },
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
                    { TypeElement.Grass, 1/2f },
                    { TypeElement.Electric, 1/2f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1f },
                    { TypeElement.Dragon, 1/2f },
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
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1f },
                    { TypeElement.Water, 1f },
                    { TypeElement.Grass, 1f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1/2f },
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
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1/2f },
                    { TypeElement.Water, 1/2f },
                    { TypeElement.Grass, 2f },
                    { TypeElement.Electric, 1f },
                    { TypeElement.Psychic, 1f },
                    { TypeElement.Ice, 1/2f },
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
                    { TypeElement.Steel, 1/2f },
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
                    { TypeElement.Fighting, 1/2f },
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
                    { TypeElement.Dark, 1/2f },
                    { TypeElement.Fairy, 1/2f }
            }
            },
            { TypeElement.Fairy, new Dictionary<TypeElement, float>
                {
                    { TypeElement.Normal, 1f },
                    { TypeElement.Fighting, 2f },
                    { TypeElement.Flying, 1f },
                    { TypeElement.Poison, 1/2f },
                    { TypeElement.Ground, 1f },
                    { TypeElement.Rock, 1f },
                    { TypeElement.Bug, 1f },
                    { TypeElement.Ghost, 1f },
                    { TypeElement.Steel, 1/2f },
                    { TypeElement.Fire, 1/2f },
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
}
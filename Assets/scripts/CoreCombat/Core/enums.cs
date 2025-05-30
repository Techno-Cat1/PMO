using UnityEngine;

namespace CoreCombat
{
    public enum MoveCategory
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

    public enum FieldCategory
    {
        Terrain,
        Room,
        Weather,
        FieldHazard
    }

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
}
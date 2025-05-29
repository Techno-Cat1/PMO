using System;

namespace CoreCombat
{
    [Serializable]
    public struct Stats
    {
        public float MaxHp;
        public float Atk;
        public float Def;
        public float SpAtk;
        public float SpDef;
        public float Speed;


        public static Stats operator +(Stats a, Stats b)        // Addition
        {
            return new Stats
            {
                MaxHp = a.MaxHp + b.MaxHp,
                Atk = a.Atk + b.Atk,
                Def = a.Def + b.Def,
                SpAtk = a.SpAtk + b.SpAtk,
                SpDef = a.SpDef + b.SpDef,
                Speed = a.Speed + b.Speed
            };
        }


        public static Stats operator -(Stats a, Stats b)        // Substraction
        {
            return new Stats
            {
                MaxHp = a.MaxHp - b.MaxHp,
                Atk = a.Atk - b.Atk,
                Def = a.Def - b.Def,
                SpAtk = a.SpAtk - b.SpAtk,
                SpDef = a.SpDef - b.SpDef,
                Speed = a.Speed - b.Speed
            };
        }


        public static Stats operator *(Stats a, float scalar)   // Multiplication
        {
            return new Stats
            {
                MaxHp = a.MaxHp * scalar,
                Atk = a.Atk * scalar,
                Def = a.Def * scalar,
                SpAtk = a.SpAtk * scalar,
                SpDef = a.SpDef * scalar,
                Speed = a.Speed * scalar
            };
        }

        public static Stats operator *(float scalar, Stats a) => a * scalar;

        public static Stats operator /(Stats a, float scalar)       // Division
        {
            if (scalar == 0f) throw new DivideByZeroException("No");

            return new Stats
            {
                MaxHp = a.MaxHp / scalar,
                Atk = a.Atk / scalar,
                Def = a.Def / scalar,
                SpAtk = a.SpAtk / scalar,
                SpDef = a.SpDef / scalar,
                Speed = a.Speed / scalar
            };
        }

        // Neutral stats
        public static readonly Stats Zero = new Stats
        {
            MaxHp = 0f,
            Atk = 0f,
            Def = 0f,
            SpAtk = 0f,
            SpDef = 0f,
            Speed = 0f
        };

        public override string ToString()
        {
            return $"HP: {MaxHp}, Atk: {Atk}, Def: {Def}, SpAtk: {SpAtk}, SpDef: {SpDef}, Spd: {Speed}";
        }
    }
}

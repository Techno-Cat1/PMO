namespace CoreCombat
{
    public class Stats
    {
        public int MaxHp, Atk, Def, SpAtk, SpDef, Speed;
    }

    public class BattleContext
    {
        public Pokemon Attacker;
        public Pokemon Defender;
        public bool Cancelled;
    }


    public interface IPokemonModifiers
    {
        void Stat_Change();
    }

    public interface ICombatModifiers
    {
        void BeforeAttack(BattleContext ctx);
        void AfterAttack(BattleContext ctx);
        void OnDeath(BattleContext ctx);
    }
}
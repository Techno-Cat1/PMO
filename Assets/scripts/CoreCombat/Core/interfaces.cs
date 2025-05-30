using UnityEngine;

namespace Collections
{
    public interface IStatusEffect
    {
        string Name { get; }
        TypeElement Element { get; }
        int Priority { get; }
        EffectResult OnApply(BattleContext ctx);
        EffectResult OnTick(BattleContext ctx);
        EffectResult OnExpire(BattleContext ctx);
    }

    public interface IFieldEffect
    {
        string Name { get; }
        int Priority { get; }
        FieldCategory FieldType { get; }
        EffectResult OnApply(BattleContext ctx);
        EffectResult OnTick(BattleContext ctx);
        EffectResult OnExpire(BattleContext ctx);
    }

    public interface IPokemonModifiers              // Not done yet
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
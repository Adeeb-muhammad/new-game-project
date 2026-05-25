using System;

public class CombatManager
{
    /// <summary>
    /// Calculates damage based on attacker's power and defender's defense.
    /// Ensures a minimum of 1 damage is always dealt.
    /// </summary>
    public int CalculateDamage(ICombatant attacker, ICombatant defender)
    {
        if (attacker == null || defender == null)
            return 0;

        int damage = attacker.AttackPower - defender.Defense;
        
        return Math.Max(1, damage);
    }

    /// <summary>
    /// Calculates damage when using an ability.
    /// The DamageMultiplier is applied to AttackPower BEFORE defense is subtracted,
    /// so abilities scale the raw offensive power rather than the post-defense remainder.
    /// Formula: (AttackPower * DamageMultiplier) - Defense, minimum 1.
    /// </summary>
    public int CalculateAbilityDamage(ICombatant attacker, ICombatant defender, Ability ability)
    {
        if (attacker == null || defender == null || ability == null)
            return 0;

        int boostedAttack = (int)(attacker.AttackPower * ability.DamageMultiplier);
        int damage = boostedAttack - defender.Defense;

        return Math.Max(1, damage);
    }
}

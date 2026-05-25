public interface ICombatant
{
    int CurrentHP { get; set; }
    int MaxHP { get; set; }
    int AttackPower { get; set; }
    int Defense { get; set; }
    int CurrentEnergy { get; set; }
    int MaxEnergy { get; set; }
}

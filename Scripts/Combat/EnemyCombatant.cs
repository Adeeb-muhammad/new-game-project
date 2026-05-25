using Godot;

/// <summary>
/// A simple enemy combatant with fixed stats.
/// Customize these values per-enemy via [Export] in the Godot Inspector.
/// </summary>
public partial class EnemyCombatant : Node, ICombatant
{
	[Export] public int CurrentHP { get; set; } = 50;
	[Export] public int MaxHP { get; set; } = 50;
	[Export] public int AttackPower { get; set; } = 12;
	[Export] public int Defense { get; set; } = 5;
	[Export] public int CurrentEnergy { get; set; } = 30;
	[Export] public int MaxEnergy { get; set; } = 30;
}

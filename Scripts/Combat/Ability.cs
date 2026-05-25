using Godot;

/// <summary>
/// Data resource for a combat ability (e.g., Missile Barrage, Shield Bash).
/// Create instances as .tres files in the editor or load them via code.
/// </summary>
[GlobalClass]
public partial class Ability : Resource
{
	[Export] public string Name { get; set; } = "";
	[Export] public string Description { get; set; } = "";

	/// <summary>
	/// Multiplier applied to base attack damage.
	/// 1.0 = normal damage, 1.5 = 50% bonus, 0.5 = half damage, etc.
	/// </summary>
	[Export] public float DamageMultiplier { get; set; } = 1.0f;

	/// <summary>
	/// Energy required to use this ability.
	/// The caller is responsible for checking if the combatant has enough energy.
	/// </summary>
	[Export] public int EnergyCost { get; set; }

	/// <summary>
	/// Minimum range required to use this ability.
	/// </summary>
	[Export] public int MinRange { get; set; } = 0;

	/// <summary>
	/// Maximum range required to use this ability.
	/// </summary>
	[Export] public int MaxRange { get; set; } = 1;
}

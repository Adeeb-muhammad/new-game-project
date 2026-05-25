using Godot;

/// <summary>
/// Component that tracks a 1D grid position for a combatant.
/// Attach this as a child node to MechCombatant or EnemyCombatant in the scene tree.
/// </summary>
[GlobalClass]
public partial class PositionComponent : Node
{
	[Export] public int Position { get; set; } = 0;
}

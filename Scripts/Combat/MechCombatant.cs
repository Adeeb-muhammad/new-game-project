using Godot;

/// <summary>
/// Adapter that wraps MechStatManager's aggregated stats into an ICombatant,
/// making any player mech ready for use with CombatManager.
/// Attach this to the same node (or a child of) your PlayerMech.
/// </summary>
public partial class MechCombatant : Node, ICombatant
{
	private MechStatManager _statManager;

	/// <summary>
	/// Tracks the mech's current HP during combat. Starts equal to MaxHP.
	/// </summary>
	public int CurrentHP { get; set; }

	/// <summary>
	/// Tracks the mech's current energy during combat. Decremented when abilities are used.
	/// </summary>
	public int CurrentEnergy { get; set; }

	/// <summary>
	/// MaxHP is derived from the mech's aggregated TotalHP stat.
	/// </summary>
	public int MaxHP
	{
		get => _statManager?.CurrentStats.TotalHP ?? 0;
		set { } // Intentional no-op: MaxHP is driven by equipped parts
	}

	/// <summary>
	/// MaxEnergy is derived from the mech's aggregated TotalEnergyCost stat,
	/// which represents the mech's total energy pool from all equipped parts.
	/// </summary>
	public int MaxEnergy
	{
		get => _statManager?.CurrentStats.TotalEnergyCost ?? 0;
		set { } // Intentional no-op: driven by equipped parts
	}

	/// <summary>
	/// AttackPower is derived from the mech's aggregated TotalAttackPower stat.
	/// </summary>
	public int AttackPower
	{
		get => _statManager?.CurrentStats.TotalAttackPower ?? 0;
		set { } // Intentional no-op: driven by equipped parts
	}

	/// <summary>
	/// Defense is derived from the mech's aggregated TotalDefense stat.
	/// </summary>
	public int Defense
	{
		get => _statManager?.CurrentStats.TotalDefense ?? 0;
		set { } // Intentional no-op: driven by equipped parts
	}

	public override void _Ready()
	{
		_statManager = GetNode<MechStatManager>("/root/MechStatManager");
	}

	/// <summary>
	/// Call this at the start of combat to initialize HP and Energy to full.
	/// </summary>
	public void InitializeForCombat()
	{
		CurrentHP = MaxHP;
		CurrentEnergy = MaxEnergy;
		GD.Print($"MechCombatant ready for combat: HP={CurrentHP}/{MaxHP}, Energy={CurrentEnergy}/{MaxEnergy}, ATK={AttackPower}, DEF={Defense}");
	}
}


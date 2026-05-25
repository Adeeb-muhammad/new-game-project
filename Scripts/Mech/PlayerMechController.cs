using Godot;

/// <summary>
/// Root controller for PlayerMech. Connects MechAssembler to MechStatManager for auto stat updates.
/// Attach this script to the PlayerMech root node.
/// </summary>
public partial class PlayerMechController : Node2D
{
	private MechAssembler _assembler;

	public override void _Ready()
	{
		_assembler = GetNode<MechAssembler>("MechAssembler");
		_assembler.MechChanged += OnMechChanged;
	}

	private void OnMechChanged()
	{
		var statManager = GetNode<MechStatManager>("/root/MechStatManager");
		statManager.CalculateStats(_assembler.GetEquippedParts());
	}
}

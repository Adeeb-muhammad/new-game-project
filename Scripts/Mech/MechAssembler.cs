using Godot;
using System.Collections.Generic;

/// <summary>
/// Attaches MechPart sprites to sockets on the PlayerMech.
/// </summary>
public partial class MechAssembler : Node2D
{
	[Export] public Node2D TorsoSocket { get; set; }
	[Export] public Node2D LegSocket { get; set; }
	[Export] public Node2D LeftArmSocket { get; set; }
	[Export] public Node2D RightArmSocket { get; set; }

	// Define the signal so PlayerMechController can listen for changes
	[Signal]
	public delegate void MechChangedEventHandler();

	// Track equipped parts
	private List<MechPart> _equippedParts = new List<MechPart>();

	// A quick reference to our global stat manager
	private MechStatManager _statManager;

	public override void _Ready()
	{
		// Make sure MechStatManager is registered as an Autoload/Singleton in Project Settings
		_statManager = GetNode<MechStatManager>("/root/MechStatManager");
	}

	// Getter for the controller to use
	public List<MechPart> GetEquippedParts()
	{
		return _equippedParts;
	}

	/// <summary>
	/// Validates the part first. If it passes, attaches it. 
	/// Returns true if successful, false if validation failed.
	/// </summary>
	public bool TryAttachPart(MechPart part, Node2D socket)
	{
		if (part == null || socket == null)
			return false;

		// 1. Validate the part against our current stats
		bool isValid = MechValidator.CanEquipPart(_statManager.CurrentStats, part);

		if (!isValid)
		{
			// Validation failed (weight or energy limit reached). 
			return false;
		}

		// 2. If valid, proceed with attaching
		AttachPart(part, socket);

		return true;
	}

	/// <summary>
	/// Creates a Sprite2D from the part's texture and adds it as a child of the socket.
	/// </summary>
	public void AttachPart(MechPart part, Node2D socket)
	{
		if (part?.Sprite == null || socket == null)
			return;

		var sprite = new Sprite2D
		{
			Texture = part.Sprite
		};
		socket.AddChild(sprite);

		// Add to list and emit the signal so PlayerMechController updates stats
		_equippedParts.Add(part);
		EmitSignal(SignalName.MechChanged);
	}
}

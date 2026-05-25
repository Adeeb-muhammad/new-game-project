using Godot;

public partial class TestAttach : Node
{
    public override void _Ready()
    {
        // Load the TestTorso resource
        var part = GD.Load<MechPart>("res://Resources/TestTorso.tres");

        // Get the MechAssembler attached to PlayerMech
        var assembler = GetNode<MechAssembler>("MechAssembler"); // adjust path if needed

        // Attach the torso to the TorsoSocket
        assembler.AttachPart(part, assembler.TorsoSocket);
    }
}

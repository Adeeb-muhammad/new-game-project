using Godot;

/// <summary>
/// Positions the sockets inside PlayerMech on _Ready.
/// </summary>
public partial class MechLayout : Node2D
{
    [Export] public Node2D TorsoSocket { get; set; }
    [Export] public Node2D LegSocket { get; set; }
    [Export] public Node2D LeftArmSocket { get; set; }
    [Export] public Node2D RightArmSocket { get; set; }

    public override void _Ready()
    {
        if (TorsoSocket != null) TorsoSocket.Position = new Vector2(0, 0);
        if (LegSocket != null) LegSocket.Position = new Vector2(0, 70);
        if (LeftArmSocket != null) LeftArmSocket.Position = new Vector2(-40, 0);
        if (RightArmSocket != null) RightArmSocket.Position = new Vector2(40, 0);
    }
}

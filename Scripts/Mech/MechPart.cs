using Godot;

/// <summary>
/// Data resource for a single mech part (weapon, armor, etc.).
/// No gameplay logic—use only for defining part stats in the editor or via code.
/// </summary>
[GlobalClass]
public partial class MechPart : Resource
{
	[Export] public string PartName { get; set; } = "";
	[Export] public int HP { get; set; }
	[Export] public int Weight { get; set; }
	[Export] public int EnergyCost { get; set; }
	[Export] public int HeatGenerated { get; set; }
	[Export] public int Cooling { get; set; }
	[Export] public int AttackPower { get; set; }
	[Export] public int Defense { get; set; }
	[Export] public Texture2D Sprite { get; set; }
}

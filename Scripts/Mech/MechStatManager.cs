using Godot;
using System.Collections.Generic;

public partial class MechStatManager : Node
{
	public struct MechStats
	{
		public int TotalHP;
		public int TotalWeight;
		public int TotalHeat;
		public int TotalCooling;
		public int TotalEnergyCost;
		public int TotalAttackPower;
		public int TotalDefense;
	}

	public MechStats CurrentStats;

	public void CalculateStats(List<MechPart> equippedParts)
	{
		CurrentStats = new MechStats();
		foreach (var part in equippedParts)
		{
			if (part == null) continue;
			CurrentStats.TotalHP += part.HP;
			CurrentStats.TotalWeight += part.Weight;
			CurrentStats.TotalHeat += part.HeatGenerated;
			CurrentStats.TotalCooling += part.Cooling;
			CurrentStats.TotalEnergyCost += part.EnergyCost;
			CurrentStats.TotalAttackPower += part.AttackPower;
			CurrentStats.TotalDefense += part.Defense;
		}
		GD.Print($"Stats Updated: Weight: {CurrentStats.TotalWeight}, HP: {CurrentStats.TotalHP}, ATK: {CurrentStats.TotalAttackPower}, DEF: {CurrentStats.TotalDefense}");
	}
}

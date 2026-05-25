using Godot;

public static class MechValidator
{
    // Define your global limits here, or pass them in dynamically if they change per-mech
    public static int MaxWeight { get; set; } = 100;
    public static int MaxEnergy { get; set; } = 50;

    /// <summary>
    /// Checks if a part can be equipped based on weight and energy cost limits.
    /// </summary>
    public static bool CanEquipPart(MechStatManager.MechStats currentStats, MechPart newPart)
    {
        if (newPart == null) return false;

        bool isWeightValid = (currentStats.TotalWeight + newPart.Weight) <= MaxWeight;
        bool isEnergyValid = (currentStats.TotalEnergyCost + newPart.EnergyCost) <= MaxEnergy;

        if (!isWeightValid)
        {
            GD.PrintErr($"Validation Failed: Adding {newPart.ResourceName} exceeds max weight! ({currentStats.TotalWeight + newPart.Weight} / {MaxWeight})");
            return false;
        }

        if (!isEnergyValid)
        {
            GD.PrintErr($"Validation Failed: Adding {newPart.ResourceName} exceeds max energy! ({currentStats.TotalEnergyCost + newPart.EnergyCost} / {MaxEnergy})");
            return false;
        }

        return true;
    }
}

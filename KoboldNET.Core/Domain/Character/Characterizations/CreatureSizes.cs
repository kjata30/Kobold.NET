namespace KoboldNET.Core.Domain.Characterizations;

/// <summary>
/// Each creature takes up a different amount of space. The <see cref="SizeCategoriesTable"/> shows how much space a creature of a particular size controls in combat. Objects sometimes use the same size categories.
/// </summary>
public enum CreatureSizes
{
    Tiny,
    Small,
    Medium,
    Large,
    Huge,
    Gargantuan
}

public static class SizeCategoriesTable
{
    public static string GetSpace(CreatureSizes size) =>
        size switch
        {
            CreatureSizes.Tiny => "2.5ft by 2.5ft",
            CreatureSizes.Small => "5ft by 5ft",
            CreatureSizes.Medium => "5ft by 5ft",
            CreatureSizes.Large => "10ft by 10ft",
            CreatureSizes.Huge => "15ft by 15ft",
            CreatureSizes.Gargantuan => "20ft by 20ft or larger",
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null)
        };
}
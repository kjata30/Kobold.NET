using KoboldNET.Core.Domain.Character;
using KoboldNET.Core.Domain.Characterizations;

namespace KoboldNET.Core.Domain.Species;

public class Species
{
    /// <summary>
    /// Every race increases one or more of a character's ability scores.
    /// </summary>
    public IEnumerable<AbilityScoreIncrease> AbilityScoreIncrease { get; set; } = null!;

    /// <summary>
    /// The age entry notes the age when a member of the race is considered an adult, as well as the race's expected lifespan. This information can help you decide how old your character is at the start of the game. You can choose any age for your character, which could provide an explanation for some of your ability scores. For example, if you play a young or very old character, your age could explain a particularly low Strength or Constitution score, while advanced age could account for a high Intelligence or Wisdom.
    /// </summary>
    public int Age { get; set; }
    
    /// <summary>
    /// Most races have tendencies toward certain alignments, described in this entry. These are not binding for player characters, but considering why your dwarf is chaotic, for example, in defiance of lawful dwarf society can help you better define your character.
    /// </summary>
    public Alignments Alignment { get; set; }
    
    /// <summary>
    /// Characters of most races are Medium, a size category including creatures that are roughly 4 to 8 feet tall. Members of a few races are Small (between 2 and 4 feet tall), which means that certain rules of the game affect them differently. The most important of these rules is that Small characters have trouble wielding heavy weapons.
    /// </summary>
    public CreatureSizes Size { get; set; }
    
    /// <summary>
    /// Your speed determines how far you can move when traveling and fighting.
    /// </summary>
    /// <remarks>
    /// Assume feet as a unit of measure.
    /// </remarks>
    public decimal Speed { get; set; }

    /// <summary>
    /// By virtue of your race, your character can speak, read, and write certain languages.
    /// </summary>
    public IEnumerable<Language> Languages { get; set; } = null!;
    
    /// <summary>
    /// Some races have subraces. Members of a subrace have the traits of the parent race in addition to the traits specified for their subrace. Relationships among subraces vary significantly from race to race and world to world.
    /// </summary>
    public ParentRace ParentRace { get; set; }

    /// <summary>
    /// The name of the species.
    /// </summary>
    public string Name { get; set; } = null!;
    
    public IEnumerable<Features>? Features { get; set; }
}
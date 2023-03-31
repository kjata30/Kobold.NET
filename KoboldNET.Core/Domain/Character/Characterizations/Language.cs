namespace KoboldNET.Core.Domain.Characterizations;

/// <summary>
/// Your race indicates the languages your character can speak by default, and your background might give you access to one or more additional languages of your choice. Note these languages on your character sheet.
/// Choose your languages from the Standard Languages table, or choose one that is common in your campaign. With your GM's permission, you can instead choose a language from the Exotic Languages table or a secret language, such as thieves' cant or the tongue of druids.
/// Some of these languages are actually families of languages with many dialects. For example, the Primordial language includes the Auran, Aquan, Ignan, and Terran dialects, one for each of the four elemental planes. Creatures that speak different dialects of the same language can communicate with one another.
/// </summary>
public class Language
{
    public string Name { get; set; }
    
    public string TypicalSpeakers { get; set; }
    
    public string Script { get; set; }
}
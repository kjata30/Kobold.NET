namespace KoboldNET.Core.Domain.Characterizations;

/// <summary>
/// A typical creature in the game world has an alignment, which broadly describes its moral and personal attitudes. Alignment is a combination of two factors: one identifies morality (good, evil, or neutral), and the other describes attitudes toward society and order (lawful, chaotic, or neutral). Thus, nine distinct alignments define the possible combinations.
/// </summary>
public enum Alignments
{
    /// <summary>
    /// Lawful good (LG) creatures can be counted on to do the right thing as expected by society. Gold dragons, paladins, and most dwarves are lawful good.
    /// </summary>
    LawfulGood,
    
    /// <summary>
    /// Neutral good (NG) folk do the best they can to help others according to their needs. Many celestials, some cloud giants, and most gnomes are neutral good.
    /// </summary>
    NeutralGood,
    
    /// <summary>
    /// Chaotic good (CG) creatures act as their conscience directs, with little regard for what others expect. Copper dragons, many elves, and unicorns are chaotic good.
    /// </summary>
    ChaoticGood,
    
    /// <summary>
    /// Lawful neutral (LN) individuals act in accordance with law, tradition, or personal codes. Many monks and some wizards are lawful neutral.
    /// </summary>
    LawfulNeutral,
    
    /// <summary>
    /// Neutral (N) is the alignment of those who prefer to steer clear of moral questions and don't take sides, doing what seems best at the time. Lizardfolk, most druids, and many humans are neutral.
    /// </summary>
    Neutral,
    
    /// <summary>
    /// Chaotic neutral (CN) creatures follow their whims, holding their personal freedom above all else. Many barbarians and rogues, and some bards, are chaotic neutral.
    /// </summary>
    ChaoticNeutral,
    
    /// <summary>
    /// Lawful evil (LE) creatures methodically take what they want, within the limits of a code of tradition, loyalty, or order. Devils, blue dragons, and hobgoblins are lawful evil.
    /// </summary>
    LawfulEvil,
    
    /// <summary>
    /// Neutral evil (NE) is the alignment of those who do whatever they can get away with, without compassion or qualms. Many drow, some cloud giants, and goblins are neutral evil.
    /// </summary>
    NeutralEvil,
    
    /// <summary>
    /// Chaotic evil (CE) creatures act with arbitrary violence, spurred by their greed, hatred, or bloodlust. Demons, red dragons, and orcs are chaotic evil.
    /// </summary>
    ChaoticEvil
}
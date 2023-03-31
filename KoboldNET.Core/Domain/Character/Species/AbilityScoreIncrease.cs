using System.ComponentModel.DataAnnotations;
using KoboldNET.Core.Domain.Characterizations;

namespace KoboldNET.Core.Domain.Species;

public class AbilityScoreIncrease : IValidatableObject
{
    public Abilities Ability { get; set; }
    
    public int Increase { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => new[]
    {
        Increase >= 0 ? ValidationResult.Success! : new ValidationResult($"{nameof(Increase)} must be positive.")
    };
}
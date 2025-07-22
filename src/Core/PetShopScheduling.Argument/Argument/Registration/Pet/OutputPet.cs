using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Registration.SpecieType;
using PetShopScheduling.Argument.Enum.Registration.PetSize;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputPet : BaseOutput<OutputPet>
{
    [Required]
    public long CustomerId { get; private set; }
    public string? Identification { get; private set; }
    public EnumSpecieType SpecieType { get; private set; }
    public string? Name { get; private set; }
    public DateOnly? BirthDate { get; private set; }
    public string? Race { get; private set; }
    public EnumPetSize? PetSize { get; private set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    public List<OutputSchedule>? ListSchedule { get; private set; }
    #endregion

    public OutputPet() { }

    [JsonConstructor]
    public OutputPet(long customerId, string? identification, EnumSpecieType specieType, string? name, DateOnly? birthDate, string? race, EnumPetSize? petSize, string? observation, List<OutputSchedule>? listSchedule)
    {
        CustomerId = customerId;
        Identification = identification;
        SpecieType = specieType;
        Name = name;
        BirthDate = birthDate;
        Race = race;
        PetSize = petSize;
        Observation = observation;
        ListSchedule = listSchedule;
    }
}
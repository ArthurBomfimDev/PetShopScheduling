using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Registration.EnumAnimalType;
using PetShopScheduling.Argument.Enum.Registration.PetSize;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdatePet : BaseInputUpdate<InputUpdatePet>
{
    public long CustomerId { get; private set; }
    public string? Identification { get; private set; }
    public EnumAnimalType AnimalType { get; private set; }
    public string? Name { get; private set; }
    public DateOnly? BirthDate { get; private set; }
    public string? Race { get; private set; }
    public EnumPetSize? PetSize { get; private set; }
    public string? Observation { get; private set; }

    public InputUpdatePet() { }

    [JsonConstructor]
    public InputUpdatePet(long customerId, string? identification, EnumAnimalType animalType, string? name, DateOnly? birthDate, string? race, EnumPetSize? petSize, string? observation)
    {
        CustomerId = customerId;
        Identification = identification;
        AnimalType = animalType;
        Name = name;
        BirthDate = birthDate;
        Race = race;
        PetSize = petSize;
        Observation = observation;
    }
}
using PetShopScheduling.Argument.Enum.EnumAnimalType;
using PetShopScheduling.Argument.Enum.PetSize;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Domain.DTO.Registration;

public class PetDTO
{
    public long CustomerId { get; private set; }
    public string? Identification { get; private set; }
    public EnumAnimalType AnimalType { get; private set; }
    public string? Name { get; private set; }
    public DateOnly? BirthDate { get; private set; }
    public string? Race { get; private set; }
    public EnumPetSize? PetSize { get; private set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    [NotMapped]
    public List<ScheduleDTO> ListSchedule { get; private set; }
    #endregion

    public PetDTO() { }

    public PetDTO(long customerId, string? identification, EnumAnimalType animalType, string? name, DateOnly? birthDate, string? race, EnumPetSize? petSize, string? observation, List<ScheduleDTO> listSchedule)
    {
        CustomerId = customerId;
        Identification = identification;
        AnimalType = animalType;
        Name = name;
        BirthDate = birthDate;
        Race = race;
        PetSize = petSize;
        Observation = observation;
        ListSchedule = listSchedule;
    }
}
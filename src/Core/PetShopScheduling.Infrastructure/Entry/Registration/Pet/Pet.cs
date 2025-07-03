using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.EnumAnimalType;
using PetShopScheduling.Argument.Enum.PetSize;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using PetShopScheduling.Infrastructure.Entry.Registration;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("pet")]
public class Pet : BaseEntry<Pet, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }  // Ver modo familia (classe auxiliar)
    [Column("identificação")]
    public string? Identification { get; private set; }
    [Column("tipo_animal")]
    public EnumAnimalType AnimalType { get; private set; }
    [Column("nome")]
    public string? Name { get; private set; }
    [Column("data_nascimento")]
    public DateOnly? BirthDate { get; private set; }
    [Column("raca")]
    public string? Race { get; private set; }
    [Column("tamanho")]
    public EnumPetSize? PetSize { get; private set; }
    [Column("observação")]
    public string? Observation { get; private set; }

    #region Virtual Properties
    [NotMapped]
    public List<Schedule> ListSchedule { get; private set; }

    public Pet() { }

    public Pet(long customerId, string? identification, EnumAnimalType animalType, string? name, DateOnly? birthDate, string race, EnumPetSize petSize, string? observation, List<Schedule> listSchedule)
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
    #endregion
}
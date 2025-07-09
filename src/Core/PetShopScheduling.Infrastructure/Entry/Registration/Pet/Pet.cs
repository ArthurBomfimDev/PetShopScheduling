using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.EnumAnimalType;
using PetShopScheduling.Argument.Enum.PetSize;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("pet")]
public class Pet : BaseEntry<Pet, PetDTO, InputCreatePet, InputUpdatePet, InputIdentityUpdatePet, InputIdentityDeletePet, InputIdentityViewPet, OutputPet>
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
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; private set; }
    [NotMapped]
    public List<Schedule>? ListSchedule { get; private set; }
    #endregion

    public Pet() { }

    public Pet(long customerId, string? identification, EnumAnimalType animalType, string? name, DateOnly? birthDate, string? race, EnumPetSize? petSize, string? observation, Customer customer, List<Schedule> listSchedule)
    {
        CustomerId = customerId;
        Identification = identification;
        AnimalType = animalType;
        Name = name;
        BirthDate = birthDate;
        Race = race;
        PetSize = petSize;
        Observation = observation;
        Customer = customer;
        ListSchedule = listSchedule;
    }

    #region Implicit Operator
    public PetDTO GetDTO()
    {
        return new PetDTO(CustomerId, Identification, AnimalType, Name, BirthDate, Race, PetSize, Observation, Customer, ListSchedule.ExplicitCast<ScheduleDTO>());
    }

    public static implicit operator PetDTO(Pet pet)
    {
        return pet.GetDTO();
    }
    #endregion
}
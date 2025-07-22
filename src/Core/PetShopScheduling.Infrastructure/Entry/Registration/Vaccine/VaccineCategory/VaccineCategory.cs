using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

public class VaccineCategory : BaseEntry<VaccineCategory, VaccineCategoryDTO, InputCreateVaccineCategory, InputUpdateVaccineCategory, InputIdentityUpdateVaccineCategory, InputIdentityDeleteVaccineCategory, InputIdentityViewVaccineCategory, OutputVaccineCategory>
{
    [Column("nome")]
    public string Name { get; private set; }
    [Column("descricao")]
    public string Description { get; private set; }
    [Column("especie_alvo")]
    public EnumTargetSpecie TargetSpecie { get; private set; }

    public VaccineCategory() { }

    public VaccineCategory(string name, string description, EnumTargetSpecie targetSpecie)
    {
        Name = name;
        Description = description;
        TargetSpecie = targetSpecie;
    }
}
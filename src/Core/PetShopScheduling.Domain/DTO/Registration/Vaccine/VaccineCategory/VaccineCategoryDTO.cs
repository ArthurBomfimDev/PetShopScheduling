using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.Registration;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.DTO.Registration;

public class VaccineCategoryDTO : BaseDTO<VaccineCategoryDTO, InputCreateVaccineCategory, InputUpdateVaccineCategory, InputIdentityUpdateVaccineCategory, InputIdentityDeleteVaccineCategory, InputIdentityViewVaccineCategory, OutputVaccineCategory>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EnumTargetSpecie TargetSpecie { get; private set; }

    public VaccineCategoryDTO() { }

    public VaccineCategoryDTO(string name, string description, EnumTargetSpecie targetSpecie)
    {
        Name = name;
        Description = description;
        TargetSpecie = targetSpecie;
    }
}
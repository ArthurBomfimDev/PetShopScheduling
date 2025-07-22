using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Registration;
using PetShopScheduling.Argument.Enum.Registration.VaccineStatus;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputVaccineCategory : BaseOutput<OutputVaccineCategory>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EnumTargetSpecie TargetSpecie { get; private set; }

    #region Virtual Properties

    #endregion

    public OutputVaccineCategory() { }

}
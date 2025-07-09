using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputService : BaseOutput<OutputService>
{
    public string Name { get; private set; }
    public string? Description { get; private set; }

    #region Virtual Properties
    public List<OutputSchedule> ListSchedule { get; private set; }
    #endregion

    public OutputService() { }

    [JsonConstructor]
    public OutputService(string name, string? description, List<OutputSchedule> listSchedule)
    {
        Name = name;
        Description = description;
        ListSchedule = listSchedule;
    }
}
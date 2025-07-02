using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Base;

public class BaseInputIdentityUpdate<TInputUpdate> where TInputUpdate : BaseInputUpdate<TInputUpdate>
{
    [Required(ErrorMessage = "O campo {0} é OBRIGATÓRIO - Identificador")]
    public long Id { get; set; }
    public TInputUpdate? InputUpdate { get; set; }

    public BaseInputIdentityUpdate() { }

    [JsonConstructor]
    public BaseInputIdentityUpdate(long id, TInputUpdate? inputUpdate)
    {
        Id = id;
        InputUpdate = inputUpdate;
    }
}

public class BaseInputIdentityUpdate_0 : BaseInputIdentityUpdate<BaseInputUpdate_0> { }
using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("endereco_usuario")]
public class CustomerAddress : BaseEntry<CustomerAddress, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }
    [Column("cep")]
    public string? CEP { get; private set; }
    [Column("bairro")]
    public string? Neighborhood { get; private set; }
    [Column("rua")]
    public string? Street { get; private set; }
    [Column("numero")]
    public string? Number { get; private set; }
    [Column("observacao")]
    public string? Observation { get; private set; }
}
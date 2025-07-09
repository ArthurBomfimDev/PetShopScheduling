using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using PetShopScheduling.Infrastructure.Entry.Registration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceShopScheduling.Infrastructure.Entry.Registration;

[Table("servico")]
public class Service : BaseEntry<Service, ServiceDTO, InputCreateService, InputUpdateService, InputIdentityUpdateService, InputIdentityDeleteService, InputIdentityViewService, OutputService>
{
    [Column("nome")]
    public string Name { get; private set; }
    [Column("descricao")]
    public string? Description { get; private set; }

    #region Virtual Properties
    [NotMapped]
    public List<Schedule>? ListSchedule { get; private set; }
    #endregion

    public Service() { }

    public Service(string name, string? description, List<Schedule>? listSchedule)
    {
        Name = name;
        Description = description;
        ListSchedule = listSchedule;
    }
}
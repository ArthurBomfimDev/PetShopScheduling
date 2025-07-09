using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Domain.DTO.Registration;

public class ServiceDTO : BaseDTO<ServiceDTO, InputCreateService, InputUpdateService, InputIdentityUpdateService, InputIdentityDeleteService, InputIdentityViewService, OutputService>
{
    [Column("nome")]
    public string Name { get; private set; }
    [Column("descricao")]
    public string? Description { get; private set; }

    #region Virtual Properties
    [NotMapped]
    public List<ScheduleDTO>? ListScheduleDTO { get; private set; }
    #endregion

    public ServiceDTO() { }

    public ServiceDTO(string name, string? description, List<ScheduleDTO>? listScheduleDTO)
    {
        Name = name;
        Description = description;
        ListScheduleDTO = listScheduleDTO;
    }
}
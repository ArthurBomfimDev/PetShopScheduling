using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Domain.Interface.Service.Registration;
using PetShopScheduling.Domain.Service.Base;

namespace PetShopScheduling.Domain.Service.Registration;

public class PetService : BaseService<PetDTO, InputCreatePet, InputUpdatePet, InputIdentityUpdatePet, InputIdentityDeletePet, InputIdentityViewPet, OutputPet, IPetRepository>, IPetService
{
    public PetService(IPetRepository repository) : base(repository) { }
}
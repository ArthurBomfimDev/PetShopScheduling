using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Domain.Interface.Service.Base;

namespace PetShopScheduling.Domain.Interface.Service.Registration;

public interface IPetService : IBaseService<PetDTO, InputCreatePet, InputUpdatePet, InputIdentityUpdatePet, InputIdentityDeletePet, InputIdentityViewPet, OutputPet, IPetRepository> { }
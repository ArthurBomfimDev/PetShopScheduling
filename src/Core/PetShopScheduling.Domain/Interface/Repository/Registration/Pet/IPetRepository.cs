using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository.Base;

namespace PetShopScheduling.Domain.Interface.Repository;

public interface IPetRepository : IBaseRepository<PetDTO, InputCreatePet, InputUpdatePet, InputIdentityUpdatePet, InputIdentityDeletePet, InputIdentityViewPet, OutputPet> { }
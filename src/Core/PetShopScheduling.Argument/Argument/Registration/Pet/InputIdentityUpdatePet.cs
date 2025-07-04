using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdatePet(long id, InputUpdatePet? inputUpdate) : BaseInputIdentityUpdate<InputUpdatePet>(id, inputUpdate) { }
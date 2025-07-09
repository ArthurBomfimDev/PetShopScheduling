using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateService(long id, InputUpdateService? inputUpdate) : BaseInputIdentityUpdate<InputUpdateService>(id, inputUpdate) { }
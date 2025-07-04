using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateReservedVaccine(long id, InputUpdateReservedVaccine? inputUpdate) : BaseInputIdentityUpdate<InputUpdateReservedVaccine>(id, inputUpdate) { }
using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateVaccine(long id, InputUpdateVaccine? inputUpdate) : BaseInputIdentityUpdate<InputUpdateVaccine>(id, inputUpdate) { }
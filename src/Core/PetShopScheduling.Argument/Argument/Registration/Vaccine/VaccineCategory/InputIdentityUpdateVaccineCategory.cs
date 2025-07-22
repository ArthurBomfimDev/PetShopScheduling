using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateVaccineCategory(long id, InputUpdateVaccineCategory? inputUpdate) : BaseInputIdentityUpdate<InputUpdateVaccineCategory>(id, inputUpdate) { }
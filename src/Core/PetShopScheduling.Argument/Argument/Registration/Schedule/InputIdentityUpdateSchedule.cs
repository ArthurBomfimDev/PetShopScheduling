using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateSchedule(long id, InputUpdateSchedule? inputUpdate) : BaseInputIdentityUpdate<InputUpdateSchedule>(id, inputUpdate) { }
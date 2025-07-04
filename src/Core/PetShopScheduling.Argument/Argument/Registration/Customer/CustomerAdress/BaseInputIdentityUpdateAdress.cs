using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class BaseInputIdentityUpdateAdress(long id, InputUpdateCustomerAdress? inputUpdate) : BaseInputIdentityUpdate<InputUpdateCustomerAdress>(id, inputUpdate) { }

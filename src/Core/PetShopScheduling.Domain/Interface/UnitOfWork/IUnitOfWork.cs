namespace PetShopScheduling.Domain.Interface.UnitOfWork;

public interface IUnitOfWork
{
    void BeginTransaction();
    void Commit();
}
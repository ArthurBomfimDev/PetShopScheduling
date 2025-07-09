namespace PetShopScheduling.Domain.Auxiliary.Helper;

public static class CollectionsHelper
{
    public static bool In(this string name, List<string> listName) => listName.Any(i => name.Contains(i));

}
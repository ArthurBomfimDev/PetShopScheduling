using System.Collections;

namespace PetShopScheduling.Argument;

public static class Conversor
{
    public static List<TDestination> ExplicitCast<TDestination>(this IList? listSource)
        where TDestination : class
    {
        if (listSource == null)
            return new List<TDestination>();

        return (from i in listSource.OfType<dynamic>() select (TDestination)i).ToList();
    }
}
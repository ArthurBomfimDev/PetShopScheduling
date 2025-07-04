namespace PetShopScheduling.Argument;

public static class Conversor
{
    public static List<TDestination>? ExplicitCast<TSource, TDestination>(this List<TSource>? listSource)
        where TSource : class, new()
        where TDestination : class, new()
    {
        return (from i in listSource select (TDestination)(dynamic)i).ToList() ?? default;
    }
}
public static class CollectionExtensions
{
    public static IEnumerable<T> Tanla<T>(this IEnumerable<T> toplam, Func<T, bool> predicate)
    {
        var juftlar = new List<T>();

        foreach(var t in toplam)
            if(predicate?.Invoke(t) == true)
                juftlar.Add(t);
            
        return juftlar;
    }
}
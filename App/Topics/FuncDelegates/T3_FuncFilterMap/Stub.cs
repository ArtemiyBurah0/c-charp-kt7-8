namespace App.Topics.FuncDelegates.T3_FuncFilterMap;

public class LinqLite
{
    public static IEnumerable<TResult> FilterMap<T, TResult>(IEnumerable<T> source, Func<T, bool> predicate, Func<T, TResult> selector)
    {
        if (source == null || predicate == null || selector == null) { throw new ArgumentNullException(); }
        List<TResult> res = new List<TResult>();
        foreach (var item in source)
        {
            if (predicate(item))
            {
                res.Add(selector(item));
            }
        }
        return res.ToArray();
    }
}

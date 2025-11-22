namespace App.Topics.Delegates.T1_BasicDelegate;

public delegate int IntUnary(int x);
public delegate bool IntPredicate(int x);

public class IntAlgorithms
{
    public static int[] Map(int[] source, IntUnary f)
    {
        if (source == null || f == null) { throw new ArgumentNullException(); }
        List<int> res = new List<int>();
        foreach (var item in source)
        {
            res.Add(f(item));
        }
        return res.ToArray();
    }
    public static int[] Filter(int[] source, IntPredicate predicate)
    {
        if (source == null || predicate == null) { throw new ArgumentNullException(); }
        List<int> res = new List<int>();
        foreach (var item in source)
        {
            if (predicate(item))
            {
                res.Add(item);
            }
        }
        return res.ToArray();
    }
}
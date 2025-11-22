namespace App.Topics.ActionDelegates.T2_ActionPipeline;

public class ActionPipeline
{
    public static int InvokeAll(string input, params Action<string>[] handlers)
    {
        if (handlers == null) { throw new ArgumentNullException(); }
        int count = 0;
        foreach (var item in handlers)
        {
            try
            {
                if (item == null) { continue; }
                item(input);
                count++;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        return count;
    }
}

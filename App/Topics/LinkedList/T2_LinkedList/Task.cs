using System.Globalization;

namespace App.Topics.LinkedList.T2_LinkedList;
public static class LinkedListTasks
{
    public static System.Collections.Generic.LinkedList<int>
        RemoveDuplicates(System.Collections.Generic.LinkedList<int> list)
    {
        if (list == null) throw new ArgumentNullException("list null");  
        var hashSet = new HashSet<int>();
        var result = new LinkedList<int>();

        foreach (var item in list)
        {
            if (!hashSet.Add(item))
                continue;
            result.AddLast(item);
        }
        return result;
    }
}
namespace App.Topics.Collections.T1_Collections;

public static class CollectionsTasks
{
    public static System.Collections.ArrayList
        FilterUniqueStringsNonGeneric(System.Collections.IEnumerable source)
    {
        var result = new System.Collections.ArrayList();
        var hashSet = new HashSet<string>();

        foreach (var item in source)
        {
            if (item is not string str)
                continue;
            if (string.IsNullOrWhiteSpace(str))
                continue;
            if(!hashSet.Add(str.Trim().ToLower()))
                continue;
            result.Add(str.Trim());
        }
        return result;
    }
    public static System.Collections.Generic.List<string>
        FilterUniqueStringsGeneric(System.Collections.Generic.IEnumerable<string> source)
    { 
        var hashSet = new HashSet<string>();

        return source
            .Where(str => !string.IsNullOrWhiteSpace(str))
            .Select(str => str.Trim())
            .Where(str => hashSet.Add(str.ToLower()))
            .ToList();
    }
}

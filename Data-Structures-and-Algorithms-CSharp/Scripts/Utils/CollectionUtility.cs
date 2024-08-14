namespace Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

public static class CollectionUtility
{
    public static int LastIndex<T>(this List<T> list)
    {
        return list.Count - 1;
    }
    
    public static int LastIndex<T>(this T[] array)
    {
        return array.Length - 1;
    }
}

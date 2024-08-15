using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;

public class CompleteBinaryTree<T> where T : IComparable<T>
{
    private readonly List<T> _list = [];

    public int Count => _list.Count;
    public int LastIndex => _list.LastIndex();
    
    public int ParentIndex(int index) => (index - 1) / 2;
    public int LeftChildIndex(int index) => (2 * index + 1);
    public int RightChildIndex(int i) => (2 * i + 2);
    public void Swap(int index1, int index2) => (_list[index1], _list[index2]) = (_list[index2], _list[index1]);
    public T Get(int index) => _list[index];
    public void Insert(T value) => _list.Add(value);
    public T? GetTop() => _list.FirstOrDefault();
    
    public void RemoveTop() 
    {
        if (_list.Count <= 0) return;
        Swap(0, _list.LastIndex());
        _list.RemoveAt(_list.LastIndex());
    }
    
    public void Print()
    {
        Console.WriteLine($"Heap: {_list.GetHashCode()}");

        var count = _list.Count;
        var depth = (int)Math.Ceiling(Math.Log2(count + 1));

        for (var level = 0; level < depth; level++)
        {
            var elementsAtLevel = (int)Math.Pow(2, level);
            var firstElementIndex = elementsAtLevel - 1;
            var lastElementIndex = Math.Min(firstElementIndex + elementsAtLevel - 1, count - 1);
                
            var spacesBetween = (int)Math.Pow(2, depth - level) - 1;
            var spacesBefore = (spacesBetween / 2);

            Console.Write(new string(' ', spacesBefore));

            for (var i = firstElementIndex; i <= lastElementIndex; i++)
            {
                Console.Write(_list[i] + new string(' ', spacesBetween));
            }

            Console.WriteLine();
        }
    }
}
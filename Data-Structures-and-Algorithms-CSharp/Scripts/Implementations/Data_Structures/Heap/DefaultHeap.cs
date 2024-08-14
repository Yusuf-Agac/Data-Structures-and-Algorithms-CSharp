using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Heap;

public class DefaultHeap<T> where T : IComparable<T>
{
    private readonly List<T> _list = [];
    
    private int ParentIndex(int index) => (index - 1) / 2;
    private int LeftChildIndex(int index) => (2 * index + 1);
    private int RightChildIndex(int i) => (2 * i + 2);
    private void Swap(int index1, int index2) => (_list[index1], _list[index2]) = (_list[index2], _list[index1]);

    private void HeapifyToBottom(int index)
    {
        var largestIndex = index;
        
        var leftIndex = LeftChildIndex(index);
        var rightIndex = RightChildIndex(index);
        
        var current = _list[index];
        
        if (_list.LastIndex() >= leftIndex && _list[leftIndex].CompareTo(current) == 1) largestIndex = leftIndex;
        if (_list.LastIndex() >= rightIndex && _list[rightIndex].CompareTo(_list[largestIndex]) == 1) largestIndex = rightIndex;

        if (largestIndex != index)
        {
            Swap(index, largestIndex);
            HeapifyToBottom(largestIndex);
        }
    }
    
    private void HeapifyToTop(int index)
    {
        if(index == 0) return;
        var parentIndex = ParentIndex(index);
        
        var current = _list[index];
        var parent = _list[parentIndex];
        if (current.CompareTo(parent) == 1)
        {
            Swap(index, parentIndex);
            HeapifyToTop(parentIndex);
        }
    }

    public void Insert(T value)
    {
        _list.Add(value);
        HeapifyToTop(_list.LastIndex());
    }
    
    public void RemoveMax() 
    {
        if (_list.Count <= 0) return;
        Swap(0, _list.LastIndex());
        _list.RemoveAt(_list.LastIndex());
        HeapifyToBottom(0);
    }

    public T? GetMax()
    {
        return _list.FirstOrDefault();
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
using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Heap;

public class DefaultHeap<T> where T : IComparable<T>
{
    private readonly CompleteBinaryTree<T> _tree = new();

    private void HeapifyToBottom(int index)
    {
        var largestIndex = index;
        
        var leftIndex = _tree.LeftChildIndex(index);
        var rightIndex = _tree.RightChildIndex(index);
        
        var current = _tree.Get(index);
        
        if (_tree.LastIndex >= leftIndex && _tree.Get(leftIndex).CompareTo(current) == 1) largestIndex = leftIndex;
        if (_tree.LastIndex >= rightIndex && _tree.Get(rightIndex).CompareTo(_tree.Get(largestIndex)) == 1) largestIndex = rightIndex;

        if (largestIndex != index)
        {
            _tree.Swap(index, largestIndex);
            HeapifyToBottom(largestIndex);
        }
    }
    
    private void HeapifyToTop(int index)
    {
        if(index == 0) return;
        var parentIndex = _tree.ParentIndex(index);
        
        var current = _tree.Get(index);
        var parent = _tree.Get(parentIndex);
        if (current.CompareTo(parent) == 1)
        {
            _tree.Swap(index, parentIndex);
            HeapifyToTop(parentIndex);
        }
    }

    public void Insert(T value)
    {
        _tree.Insert(value);
        HeapifyToTop(_tree.LastIndex);
    }
    
    public void RemoveMax() 
    {
        if (_tree.Count <= 0) return;
        _tree.Swap(0, _tree.LastIndex);
        _tree.RemoveTop();
        HeapifyToBottom(0);
    }

    public T? GetMax()
    {
        return _tree.GetTop();
    }
    
    public void Print()
    {
        _tree.Print();
    }
}
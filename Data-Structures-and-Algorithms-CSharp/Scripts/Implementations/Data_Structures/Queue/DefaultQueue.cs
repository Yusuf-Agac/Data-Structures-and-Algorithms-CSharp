using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Queue;

public class DefaultQueue<T>(int capacity)
{
    private readonly T[] _array = new T[capacity];
    private readonly int _capacity = capacity;
    
    private int _frontIndex = -1;
    private int _rearIndex = -1;
    
    public bool IsEmpty => _frontIndex <= -1 && _rearIndex <= -1;
    public bool IsFull => Usage >= _capacity;
    
    private int Usage => (_rearIndex - _frontIndex) + 1;
    private int LastIndex => _array.Length - 1;
    
    public T? Peek()
    {
        if(IsEmpty) Console.WriteLine("Queue is not valid for Peek");
        return IsEmpty ? default : _array[_frontIndex];
    }

    public void Enqueue(T item)
    {
        if (IsFull)
        {
            Console.WriteLine("Queue is not valid for Enqueue");
            return;
        }
        if (IsEmpty) StartIndexes();
        if (IsShiftNeeded()) ShiftArray();
        _rearIndex++;
        _array[_rearIndex] = item;
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Queue is not valid for Dequeue");
            return default;
        }

        var result = _array[_frontIndex];
        _array[_frontIndex] = default;
        if (Usage == 1) EndIndexes();
        else _frontIndex++;
        return result;
    }
    
    public void Print()
    {
        Console.Write("Current Queue: ");
        foreach (var item in _array) Console.Write($"{item.ToString()}, ");
        ConsoleUtility.NextLine();
        Console.WriteLine($"FrontIndex: {_frontIndex} - RearIndex: {_rearIndex}");
    }
    
    private void ShiftArray()
    {
        for (int i = _frontIndex; i <= _rearIndex; i++)
        {
            _array[i - 1] = _array[i];
        }
        _frontIndex--;
        _rearIndex--;
    }

    private bool IsShiftNeeded()
    {
        return _rearIndex >= LastIndex && Usage <= _capacity;
    }

    private void StartIndexes()
    {
        _frontIndex = 0;
    }

    private void EndIndexes()
    {
        _frontIndex = -1;
        _rearIndex = -1;
    }
}
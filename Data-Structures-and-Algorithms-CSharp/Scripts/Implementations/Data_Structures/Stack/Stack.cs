using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Stack;

public class Stack<T>(int capacity)
{
    private readonly T?[] _array = new T?[capacity];
    private int _topIndex = -1;
    
    private readonly int _capacity = capacity;
    private readonly int _lastIndex = capacity - 1;

    public bool IsEmpty => _topIndex <= -1;
    public bool IsFull => _topIndex >= _lastIndex;
    public T? Peek() => IsEmpty ? default : _array[_topIndex];

    public void Push(T? item)
    {
        if (IsValidForPush())
        {
            _topIndex++;
            _array[_topIndex] = item;
            return;
        }
        Console.WriteLine("Stack is not valid for pushing new objects");
    }

    private bool IsValidForPush()
    {
        return !IsFull;
    }

    public T? Pop()
    {
        if (IsValidForPop())
        {
            var result = _array[_topIndex];
            _array[_topIndex] = default;
            _topIndex--;
            return result;
        }
        Console.WriteLine("Stack is not valid for poping new objects");
        return default;
    }

    private bool IsValidForPop()
    {
        return !IsEmpty;
    }

    public void PrintCurrentStack()
    {
        Console.Write("Current Stack: ");
        foreach (var item in _array) Console.Write($"{item.ToString()}, ");
        ConsoleUtility.NextLine();
    }
}
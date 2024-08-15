using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Linked_List;

public class DefaultLinkedList<T>
{
    private SingleNode<T> _head;
    private bool IsEmpty => _head == null;

    public void InsertToHead(T item)
    {
        if (IsEmpty)
        {
            _head = new SingleNode<T>(item);
            return;
        }
        var newHead = new SingleNode<T>(item);
        newHead.Next = _head;
        _head = newHead;
    }

    public void InsertToTail(T item)
    {
        if (IsEmpty)
        {
            _head = new SingleNode<T>(item);
            return;
        }
        var lastNode = GetLastNode();
        var newTail = new SingleNode<T>(item);
        lastNode.Next = newTail;
    }

    public void DeleteFromHead()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Linked List is not valid for DeleteAtTheHead");
            return;
        }
        _head = _head.Next;
    }

    public void DeleteFromTail()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Linked List is not valid for DeleteAtTheTail");
            return;
        }
        var currentNode = _head;
        if (currentNode.Next == null) _head = null;
        while (currentNode.Next.Next != null) currentNode = currentNode.Next;
        currentNode.Next = null;
    }

    public SingleNode<T> SearchNode(T item)
    {
        if (IsEmpty)
        {
            Console.WriteLine("Linked List is not valid for SearchNode");
            return null;
        }
        var currentNode = _head;
        while (currentNode != null)
        {
            if (Equals(currentNode.Item, item)) return currentNode;
            currentNode = currentNode.Next;
        }
        return null;
    }

    private SingleNode<T> GetLastNode()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Linked List is not valid for GetLastNode");
            return null;
        }
        var currentNode = _head;
        while (currentNode.Next != null) currentNode = currentNode.Next;
        return currentNode;
    }

    public void Print()
    {
        var currentNode = _head;
        Console.Write("Linked List: ");
        while (currentNode != null)
        {
            Console.Write($"{currentNode.Item}, ");
            currentNode = currentNode.Next;
        }
        ConsoleUtility.NextLine();
    }
}
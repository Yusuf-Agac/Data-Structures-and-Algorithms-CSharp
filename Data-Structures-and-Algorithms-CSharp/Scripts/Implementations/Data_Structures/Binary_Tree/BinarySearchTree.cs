using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;

public class BinarySearchTree<T> where T : IComparable<T>
{
    private DoubleNode<T> _head;

    public void Insert(T value)
    {
        _head = InsertRecursively(_head, new DoubleNode<T>(value));
    }
    
    public void Remove(T value) {
        RemoveRecursively(_head, value);
    }
    
    public void InorderTraversal() 
    {
        InorderRecursively(_head);
        ConsoleUtility.NextLine();
    }

    private DoubleNode<T> InsertRecursively(DoubleNode<T> currentNode, DoubleNode<T> newNode)
    {
        if (currentNode == null)
        {
            currentNode = newNode;
            return currentNode;
        }

        var comparisonResult = newNode.Item.CompareTo(currentNode.Item);
        switch (comparisonResult)
        {
            case -1:
                currentNode.Left = InsertRecursively(currentNode.Left, newNode);
                break;
            case 1:
                currentNode.Right = InsertRecursively(currentNode.Right, newNode);
                break;
            case 0:
                Console.WriteLine($"You cant insert same value to binary search tree");
                return currentNode;
        }
        return currentNode;
    }
    
    private DoubleNode<T> RemoveRecursively(DoubleNode<T> currentNode, T value)
    {
        if (currentNode == null) return currentNode;

        var comparisonResult = value.CompareTo(currentNode.Item);
        switch (comparisonResult)
        {
            case -1:
                currentNode.Left = RemoveRecursively(currentNode.Left, value);
                break;
            case 1:
                currentNode.Right = RemoveRecursively(currentNode.Right, value);
                break;
            case 0:
                if (currentNode.Left == null) return currentNode.Right;
                if (currentNode.Right == null) return currentNode.Left;

                currentNode.Item = MinValue(currentNode.Right);
                currentNode.Right = RemoveRecursively(currentNode.Right, currentNode.Item);
                return _head;
        }
        
        return currentNode;
    }

    private T MinValue(DoubleNode<T> currentNode)
    {
        while (currentNode.Left != null) currentNode = currentNode.Left;
        return currentNode.Item;
    }
    
    private void InorderRecursively(DoubleNode<T> currentNode)
    {
        if (currentNode == null) return;
        InorderRecursively(currentNode.Left);
        Console.Write(currentNode.Item + " -> ");
        InorderRecursively(currentNode.Right);
    }
}
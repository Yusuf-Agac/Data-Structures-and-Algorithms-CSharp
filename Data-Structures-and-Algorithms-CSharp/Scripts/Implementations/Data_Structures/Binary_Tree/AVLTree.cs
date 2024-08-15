using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;

public class AVLTree<T> where T : IComparable<T>
{
    private AVLNode<T> _root;

    public void Insert(T value)
    {
        _root = InsertRecursively(_root, value);
    }

    public void Delete(T value)
    {
        _root = DeleteRecursively(_root, value);
    }

    public bool Contains(T value)
    {
        return ContainsRecursively(_root, value);
    }

    public void InOrderTraversal(Action<T> action)
    {
        InOrderRecursively(_root, action);
        ConsoleUtility.NextLine();
    }

    private AVLNode<T> InsertRecursively(AVLNode<T> currentNode, T value)
    {
        if (currentNode == null) return new AVLNode<T>(value);

        var comparison = value.CompareTo(currentNode.Item);
        switch (comparison)
        {
            case < 0:
                currentNode.Left = InsertRecursively(currentNode.Left, value);
                break;
            case > 0:
                currentNode.Right = InsertRecursively(currentNode.Right, value);
                break;
            default:
                Console.WriteLine($"You cant insert same value to avl tree");
                return currentNode;
        }

        UpdateHeight(currentNode);
        return Balance(currentNode);
    }

    private AVLNode<T> DeleteRecursively(AVLNode<T> currentNode, T value)
    {
        if (currentNode == null) return null;

        var comparison = value.CompareTo(currentNode.Item);
        switch (comparison)
        {
            case < 0:
                currentNode.Left = DeleteRecursively(currentNode.Left, value);
                break;
            case > 0:
                currentNode.Right = DeleteRecursively(currentNode.Right, value);
                break;
            default:
            {
                if (currentNode.Left == null || currentNode.Right == null)
                {
                    currentNode = currentNode.Left ?? currentNode.Right;
                }
                else
                {
                    var minNode = FindMin(currentNode.Right);
                    currentNode.Item = minNode.Item;
                    currentNode.Right = DeleteRecursively(currentNode.Right, minNode.Item);
                }
                break;
            }
        }

        if (currentNode == null) return null;

        UpdateHeight(currentNode);
        return Balance(currentNode);
    }

    private AVLNode<T> FindMin(AVLNode<T> currentNode)
    {
        while (currentNode.Left != null) currentNode = currentNode.Left;
        return currentNode;
    }

    private bool ContainsRecursively(AVLNode<T> currentNode, T value)
    {
        if (currentNode == null) return false;

        var comparison = value.CompareTo(currentNode.Item);
        switch (comparison)
        {
            case < 0:
                return ContainsRecursively(currentNode.Left, value);
            case > 0:
                return ContainsRecursively(currentNode.Right, value);
            default:
                return true;
        }
    }

    private void InOrderRecursively(AVLNode<T> currentNode, Action<T> action)
    {
        if (currentNode == null) return;

        InOrderRecursively(currentNode.Left, action);
        action(currentNode.Item);
        InOrderRecursively(currentNode.Right, action);
    }

    private void UpdateHeight(AVLNode<T> node)
    {
        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
    }

    private int GetHeight(AVLNode<T> node)
    {
        return node?.Height ?? 0;
    }

    private int GetBalanceFactor(AVLNode<T> node)
    {
        return GetHeight(node.Left) - GetHeight(node.Right);
    }

    private AVLNode<T> Balance(AVLNode<T> node)
    {
        var balanceFactor = GetBalanceFactor(node);

        switch (balanceFactor)
        {
            case > 1:
            {
                if (GetBalanceFactor(node.Left) < 0)
                    node.Left = RotateLeft(node.Left);

                return RotateRight(node);
            }
            case < -1:
            {
                if (GetBalanceFactor(node.Right) > 0)
                    node.Right = RotateRight(node.Right);

                return RotateLeft(node);
            }
            default:
                return node;
        }
    }

    private AVLNode<T> RotateLeft(AVLNode<T> node)
    {
        var newRoot = node.Right;
        node.Right = newRoot.Left;
        newRoot.Left = node;

        UpdateHeight(node);
        UpdateHeight(newRoot);

        return newRoot;
    }

    private AVLNode<T> RotateRight(AVLNode<T> node)
    {
        var newRoot = node.Left;
        node.Left = newRoot.Right;
        newRoot.Right = node;

        UpdateHeight(node);
        UpdateHeight(newRoot);

        return newRoot;
    }
}
namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;

public class DoubleNode<T>(T item)
{
    public T Item = item;
    public DoubleNode<T> Left;
    public DoubleNode<T> Right;
}
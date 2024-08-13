namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;

public class LinearNode<T>
{
    public T Item;
    public LinearNode<T> Next;

    public LinearNode(T item)
    {
        Item = item;
    }
    
    public LinearNode(T item, LinearNode<T> next)
    {
        Item = item;
        Next = next;
    }
}
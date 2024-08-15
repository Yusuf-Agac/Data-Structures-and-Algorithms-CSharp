namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;

public class MultipleNode<T>(T item)
{
    public T Item = item;
    public List<MultipleNode<T>> Edges = [];
}
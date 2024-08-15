namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Node;

public class AVLNode<T>(T item)
{
    public T Item = item;
    public AVLNode<T> Left;
    public AVLNode<T> Right;
    public int Height = 1;
}
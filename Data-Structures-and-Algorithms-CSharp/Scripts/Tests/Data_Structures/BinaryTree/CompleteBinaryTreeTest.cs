using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.BinaryTree;

public class CompleteBinaryTreeTest
{
    public static void Test()
    {
        var tree = new CompleteBinaryTree<int>();

        ConsoleUtility.PrintHyphens();
        tree.Print();
        ConsoleUtility.PrintHyphens();
        
        tree.Insert(1);
        Console.WriteLine($"Insert: 1");
        tree.Print();
        ConsoleUtility.PrintHyphens();

        tree.Insert(2);
        Console.WriteLine($"Insert: 2");
        tree.Print();
        ConsoleUtility.PrintHyphens();
        
        tree.Insert(3);
        Console.WriteLine($"Insert: 3");
        tree.Print();
        ConsoleUtility.PrintHyphens();

        tree.Insert(4);
        Console.WriteLine($"Insert: 4");
        tree.Print();
        ConsoleUtility.PrintHyphens();
        
        tree.RemoveTop();
        Console.WriteLine($"Remove Top");
        tree.Print();
        ConsoleUtility.PrintHyphens();

        var max = tree.GetTop();
        Console.WriteLine($"Get Top: {max}");
        tree.Print();
        ConsoleUtility.PrintHyphens();
    }
}
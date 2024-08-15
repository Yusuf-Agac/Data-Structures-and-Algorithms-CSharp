using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.BinaryTree;

public static class BinarySearchTreeTest
{
    public static void Test()
    {
        var tree = new BinarySearchTree<int>();

        ConsoleUtility.PrintHyphens();
        tree.InorderTraversal();
        ConsoleUtility.PrintHyphens();

        const int amount = 15;
        for (var i = 0; i < amount; i++)
        {
            tree.Insert(i);
            Console.WriteLine($"Insert: {i}");
            tree.InorderTraversal();
            ConsoleUtility.PrintHyphens();
        }
        
        tree.Remove(5);
        Console.WriteLine($"Remove: 5");
        tree.InorderTraversal();
        ConsoleUtility.PrintHyphens();
        
        tree.Remove(12);
        Console.WriteLine($"Remove: 12");
        tree.InorderTraversal();
        ConsoleUtility.PrintHyphens();
    }
}
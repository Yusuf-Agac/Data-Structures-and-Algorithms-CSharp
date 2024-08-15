using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Binary_Tree;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.BinaryTree;

public static class AVLTreeTest
{
    public static void Test()
    {
        var tree = new AVLTree<int>();
        
        var expression = (int value) => Console.Write(value + " -> ");

        ConsoleUtility.PrintHyphens();
        tree.InOrderTraversal(expression);
        ConsoleUtility.PrintHyphens();

        const int amount = 15;
        for (var i = 0; i < amount; i++)
        {
            tree.Insert(i);
            Console.WriteLine($"Insert: {i}");
            tree.InOrderTraversal(expression);
            ConsoleUtility.PrintHyphens();
        }
        
        var isContain = tree.Contains(2);
        Console.WriteLine($"Contains 2: {isContain}");
        tree.InOrderTraversal(expression);
        ConsoleUtility.PrintHyphens();
        
        tree.Delete(2);
        Console.WriteLine($"Delete: 2");
        tree.InOrderTraversal(expression);
        ConsoleUtility.PrintHyphens();
        
        isContain = tree.Contains(2);
        Console.WriteLine($"Contains 2: {isContain}");
        tree.InOrderTraversal(expression);
        ConsoleUtility.PrintHyphens();
        
        tree.Delete(3);
        Console.WriteLine($"Delete: 3");
        tree.InOrderTraversal(expression);
        ConsoleUtility.PrintHyphens();
        
        tree.Delete(4);
        Console.WriteLine($"Delete: 4");
        tree.InOrderTraversal(expression);
        ConsoleUtility.PrintHyphens();
    }
}
using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Linked_List;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Linked_List;

public static class LinkedListTest
{
    public static void Test()
    {
        var list = new Implementations.Data_Structures.Linked_List.LinkedList<int>();

        ConsoleUtility.PrintHyphens();
        list.Print();
        ConsoleUtility.PrintHyphens();
        
        list.InsertToHead(1);
        Console.WriteLine($"Insert at Head: 1");
        list.Print();
        ConsoleUtility.PrintHyphens();

        list.InsertToTail(2);
        Console.WriteLine($"Insert at Tail: 2");
        list.Print();
        ConsoleUtility.PrintHyphens();
        
        list.InsertToHead(0);
        Console.WriteLine($"Insert at Head: 0");
        list.Print();
        ConsoleUtility.PrintHyphens();
        
        list.DeleteFromHead();
        Console.WriteLine($"Delete at Head");
        list.Print();
        ConsoleUtility.PrintHyphens();
        
        list.DeleteFromTail();
        Console.WriteLine($"Delete at Tail");
        list.Print();
        ConsoleUtility.PrintHyphens();
        
        list.InsertToTail(2);
        Console.WriteLine($"Insert at Tail: 2");
        list.Print();
        ConsoleUtility.PrintHyphens();

        var searchedNode = list.SearchNode(1);
        Console.WriteLine($"Searched For 1: {searchedNode}");
        list.Print();
        ConsoleUtility.PrintHyphens();
    }
}
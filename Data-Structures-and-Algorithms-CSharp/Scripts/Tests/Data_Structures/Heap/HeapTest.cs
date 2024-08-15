using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Heap;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Heap;

public static class HeapTest
{
    public static void Test()
    {
        var heap = new Heap<int>();

        ConsoleUtility.PrintHyphens();
        heap.Print();
        ConsoleUtility.PrintHyphens();
        
        heap.Insert(1);
        Console.WriteLine($"Insert: 1");
        heap.Print();
        ConsoleUtility.PrintHyphens();

        heap.Insert(2);
        Console.WriteLine($"Insert: 2");
        heap.Print();
        ConsoleUtility.PrintHyphens();
        
        heap.Insert(3);
        Console.WriteLine($"Insert: 3");
        heap.Print();
        ConsoleUtility.PrintHyphens();

        heap.Insert(4);
        Console.WriteLine($"Insert: 4");
        heap.Print();
        ConsoleUtility.PrintHyphens();
        
        heap.RemoveMax();
        Console.WriteLine($"Remove Max");
        heap.Print();
        ConsoleUtility.PrintHyphens();

        var max = heap.GetMax();
        Console.WriteLine($"Get Max: {max}");
        heap.Print();
        ConsoleUtility.PrintHyphens();
    }
}
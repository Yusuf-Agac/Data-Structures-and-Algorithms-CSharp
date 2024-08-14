using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Hash_Table;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Hash_Table;

public static class DefaultHashTableTest
{
    public static void Test()
    {
        var hashTable = new DefaultHashTable<int, int>(10);
        
        ConsoleUtility.PrintHyphens();
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(0, 0);
        Console.WriteLine($"Add: 0, 0");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(1, 1);
        Console.WriteLine($"Add: 1, 1");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(2, 2);
        Console.WriteLine($"Add: 2, 2");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(3, 3);
        Console.WriteLine($"Add: 3, 3");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(12, 4);
        Console.WriteLine($"Add: 12, 4");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(33, 5);
        Console.WriteLine($"Add: 33, 5");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Add(457, 6);
        Console.WriteLine($"Add: 457, 6");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        var value = hashTable.GetValue(457);
        Console.WriteLine($"GetValue: 457");
        Console.WriteLine($"Result: {value}");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
        
        hashTable.Remove(33);
        Console.WriteLine($"Remove: 33");
        hashTable.Print();
        ConsoleUtility.PrintHyphens();
    }
}
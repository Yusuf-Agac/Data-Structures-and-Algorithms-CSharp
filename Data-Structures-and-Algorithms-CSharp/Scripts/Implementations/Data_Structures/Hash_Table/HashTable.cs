using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Hash_Table;

public class HashTable<TK, TV>
{
    private readonly LinkedList<KeyValuePair<TK, TV>>[] _buckets;
    private readonly int _initialSize;

    public HashTable(int initialSize)
    {
        _initialSize = initialSize;
        _buckets = new LinkedList<KeyValuePair<TK, TV>>[_initialSize];
        InitializeBuckets();
    }

    public void Add(TK key, TV value)
    {
        var bucketIndex = GetBucketIndex(key);
        _buckets[bucketIndex].AddFirst(new KeyValuePair<TK, TV>(key, value));
    }

    public void Remove(TK key)
    {
        var bucketIndex = GetBucketIndex(key);
        var current = _buckets[bucketIndex].First;

        while (current != null)
        {
            if (current.Value.Key.Equals(key))
            {
                _buckets[bucketIndex].Remove(current);
                return;
            }

            current = current.Next;
        }
    }

    public TV GetValue(TK key)
    {
        var bucketIndex = GetBucketIndex(key);
        var current = _buckets[bucketIndex].First;

        while (current != null)
        {
            if (current.Value.Key.Equals(key))
            {
                return current.Value.Value;
            }

            current = current.Next;
        }

        return default;
    }

    public void Print()
    {
        Console.WriteLine($"Hash Table: {_buckets.GetHashCode()}");
        for (var i = 0; i < _initialSize; i++)
        {
            Console.Write($"{i}. Bucket: ");
            foreach (var pair in _buckets[i])
            {
                Console.Write($"({pair.Key}, {pair.Value})/");
            }
            ConsoleUtility.NextLine();
        }
    }

    private int GetBucketIndex(TK key)
    {
        var hashCode = key.GetHashCode();
        return Math.Abs(hashCode % _initialSize);
    }
    
    private void InitializeBuckets()
    {
        for (var i = 0; i < _initialSize; i++)
        {
            _buckets[i] = new LinkedList<KeyValuePair<TK, TV>>();
        }
    }
}
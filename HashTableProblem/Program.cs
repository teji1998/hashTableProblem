using System;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hash table problem !! ");
            MapNode<int, string> hash = new MapNode<int, string>(6);
            
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");
            Frequency freq = new Frequency();

            freq.WordFrequency(hash);
                }
    }
}

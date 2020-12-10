using System;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hash table problem !! ");
            MapNode<int, string> hash = new MapNode<int, string>(6);

            /*   hash.AddData(0, "To");
               hash.AddData(1, "be");
               hash.AddData(2, "or");
               hash.AddData(3, "not");
               hash.AddData(4, "to");
               hash.AddData(5, "be");*/

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] breakParagraph = paragraph.Split(" ");
            int key = 0;
           
            foreach (string word in breakParagraph)
            {
                hash.AddData(key, word);
                key ++;
            }
            Frequency freq = new Frequency();

            freq.WordFrequency(hash);
            freq.RemoveData(hash,"are");
         }
    }
}

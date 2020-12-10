using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    public class Frequency
    {
        
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        public void Remove(MapNode<int, string> hash, string word)
        {
            
            for (int key = 0; key < hash.size; key++)
            {
                if (hash.Get(key).Equals(word))
                {
                    hash.Remove(key);
                    Console.WriteLine($"Removed {word} from paragraph");
                }
            }
        }

        public void WordFrequency(MapNode<int, string> hash)
        {
            for (int key = 0; key < hash.size; key++)
            {
                frequency.TryAdd(hash.Get(key).ToLower(), 0);
                frequency[hash.Get(key).ToLower()]++;
            }
            foreach (KeyValuePair<string, int> item in frequency)
            {
                Console.WriteLine($"frequency of word '{item.Key}' is {item.Value}");
            }
        }

       
    }
}

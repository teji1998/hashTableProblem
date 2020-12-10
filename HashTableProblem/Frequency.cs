using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    public class Frequency
    {
        //To create a dictionary
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        /// <summary>
        /// To remove a particular word from hash table
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="word"></param>
        public void RemoveData(MapNode<int, string> hash, string word)
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

        /// <summary>
        /// To get frequency of the words
        /// </summary>
        /// <param name="hash"></param>
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

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    public class Frequency
    {
        
        Dictionary<string, int> frequency = new Dictionary<string, int>();
       
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

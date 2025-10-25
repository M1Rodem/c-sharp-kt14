using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Topics.Dictionary.T3_Dictionary;

public static class DictionaryTasks
{
    public static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>>
        TopNWords(string text, int n)
    {
        if (string.IsNullOrWhiteSpace(text) || n <= 0)
        {
            return new List<KeyValuePair<string, int>>();
        }

        string textLower = text.ToLower();

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        StringBuilder currentWord = new StringBuilder();

        for (int i = 0; i < textLower.Length; i++)
        {
            char c = textLower[i];

            if (char.IsLetterOrDigit(c))
            {
                currentWord.Append(c);
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    string word = currentWord.ToString();
                    if (wordCounts.ContainsKey(word))
                    {
                        wordCounts[word]++;
                    }
                    else
                    {
                        wordCounts[word] = 1;
                    }
                    currentWord.Clear();
                }
            }
        }

        if (currentWord.Length > 0)
        {
            string word = currentWord.ToString();
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }
        var sortedWords = wordCounts
            .OrderByDescending(pair => pair.Value)  
            .ThenBy(pair => pair.Key)    
            .Take(n)
            .ToList();

        return sortedWords;
    }
}
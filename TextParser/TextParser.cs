//--------------------------------------------------------------------------------------------------|
// Filename: TextParser.cs                                                                          |
// Date Created: 20/09/2013                                                                         |
// Date Modified: 22/09/2013                                                                        |
//--------------------------------------------------------------------------------------------------|

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    static class TextParser
    {
        // The method used to parse a given string into seperate sentences, using various filtering parameters.
        public static List<String> Parse(string data, string seperator, string afterSeperator, string include, string exclude)
        {
            List<String> result = new List<string>();

            // Split the data into an initial set of strings to be modified later
            String[] sentences = data.Split(seperator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (afterSeperator.Length != 0)
            {
                for (int i = 0; i < sentences.Length; i++)
                {
                    // Remove any white space in the seperated sentences to improve readability
                    RemoveWhiteSpace(ref sentences[i]);
                    bool found = true;

                    // Check to see if the characters at the beginning of any given sentence match the characters to include after the seperator
                    for (int j = 0; j < afterSeperator.Length; j++)
                    {
                        if (sentences[i][j] != afterSeperator[j])
                        {
                            found = false;
                        }
                    }
                    // If the characters are found, then remove them from the second string and add them to the first string
                    if (found)
                    {
                        sentences[i - 1] += afterSeperator;
                        sentences[i] = sentences[i].Remove(0, afterSeperator.Length);
                        RemoveWhiteSpace(ref sentences[i]);
                    }
                }
            }
            // Add the results to the string
            result.AddRange(sentences);
            foreach (string sentence in result)
            {
                // If the exclude characters are found, then remove the string from the results
                if (exclude != "" && sentence.Contains(exclude))
                {
                    result.Remove(sentence);
                }
                // If the include characters are not found, then remove the string from the results.
                else if (include != "" && !sentence.Contains(include))
                {
                    result.Remove(sentence);
                }
            }
            return result;
        }

        // Split the string into seperate words and return a list containing all relevant word information
        public static List<WordInformation> ParseIntoWords(string data)
        {
            List<String> words = data.Split(' ').ToList();
            List<WordInformation> result = new List<WordInformation>();
            WordInformation precedingInfo = null;
            foreach (String word in words)
            {
                AddToSet(ref result, new WordInformation(word), ref precedingInfo);
            }
            return result;
        }

        // Remove the white space at the start of a string.
        private static void RemoveWhiteSpace(ref String str)
        {
            while (str[0] == '\n' || str[0] == ' ')
            {
                str = str.Remove(0, 1);
            }
        }

        // Add a given word to the list if it has not already occured in the list, otherwise increase the count variable of the existing word.
        private static void AddToSet(ref List<WordInformation> set, WordInformation info, ref WordInformation previousInfo)
        {
            bool found = false;

            WordInformation foundInfo = null;
            foreach (WordInformation wordInfo in set)
            {
                if (wordInfo.Word == info.Word)
                {
                    foundInfo = wordInfo;
                    wordInfo.Count++;
                    found = true;
                    break;
                }
                
            }
            if (!found)
            {
                foundInfo = info;
            }
            if (previousInfo != null)
            {
                foundInfo.AddNeighbouringWord(previousInfo.Word, true);
                previousInfo.AddNeighbouringWord(foundInfo.Word, false);
            }
            previousInfo = foundInfo;

            if (!found)
            {
                set.Add(foundInfo);
            }
        }
    }
}

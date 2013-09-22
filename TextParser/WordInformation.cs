//--------------------------------------------------------------------------------------------------|
// Filename: WordInformation.cs                                                                     |
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
    // Used to store information about words neighbouring any given word stored in the word information class
    class NeighbouringWordInformation
    {
        public string Word;
        public int Count;

        public NeighbouringWordInformation(string word = "", int count = 1)
        {
            Word = word;
            Count = count;
        }
        public static bool operator <(NeighbouringWordInformation op1, NeighbouringWordInformation op2)
        {
            return op1.Word.CompareTo(op2.Word) == -1 ? true : false;
        }
        public static bool operator >(NeighbouringWordInformation op1, NeighbouringWordInformation op2)
        {
            return op1.Word.CompareTo(op2.Word) == 1 ? true : false;
        }

        public static bool operator ==(NeighbouringWordInformation op1, NeighbouringWordInformation op2)
        {
            return op1.Word.CompareTo(op2.Word) == 0 ? true : false;
        }
        public static bool operator !=(NeighbouringWordInformation op1, NeighbouringWordInformation op2)
        {
            return op1.Word.CompareTo(op2.Word) != 0 ? true : false;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

    // Used to store information about any words in a given string
    class WordInformation
    {
        public enum WORDTYPE { PREVIOUS, NEXT };
        private string _word;
        public string Word { get{ return _word; } set{ _word = value; } }

        // The maximum amount of times that this word is used in a sentence
        private int _maxUsedInSentence;
        public int MaxUsedInSentence { get { return _maxUsedInSentence; } set { _maxUsedInSentence = value; } }

        // How many times the word appears in the parsed data
        private int _count;
        public int Count { get { return _count; } set { _count = value; } }

        private List<NeighbouringWordInformation> _previousWords, _nextWords;

        public WordInformation(string word = "")
        {
            _word = word;
            _maxUsedInSentence = 0;
            _previousWords = new List<NeighbouringWordInformation>();
            _nextWords = new List<NeighbouringWordInformation>();
        }

        // Add a given word to their respective lists to calculate basic information about the location of a given word in relation to 
        // the previous or next word
        public void AddNeighbouringWord(string word, bool preceding)
        {
            NeighbouringWordInformation info = new NeighbouringWordInformation(word);
            if (preceding)
            {
                AddToSet(ref _previousWords, info);
            }
            else
            {
                AddToSet(ref _nextWords, info);
            }
        }

        // Determine which word that appears the maximum amount of times before or after the current word
        public void GetWordStats(ref int max, ref string word, WORDTYPE wordType = WORDTYPE.PREVIOUS)
        {
            max = 0;
            word = "";

            switch (wordType)
            {
                case WORDTYPE.PREVIOUS:
                    CalculateStats(ref max, ref word, ref _previousWords);
                    break;
                case WORDTYPE.NEXT:
                    CalculateStats(ref max, ref word, ref _nextWords);
                    break;
            }
        }

        private void CalculateStats(ref int max, ref string word, ref List<NeighbouringWordInformation> wordList)
        {
            foreach (NeighbouringWordInformation info in wordList)
            {
                if (info.Count > max)
                {
                    max = info.Count;
                    word = info.Word;
                }
            }
        }

        // Add a neighbouring word to the set passed in as a parameter
        private void AddToSet(ref List<NeighbouringWordInformation> set, NeighbouringWordInformation info)
        {
            bool found = false;
            foreach (NeighbouringWordInformation wordInfo in set)
            {
                if (wordInfo == info)
                {
                    wordInfo.Count++;
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                set.Add(info);
            }
        }
    }
}

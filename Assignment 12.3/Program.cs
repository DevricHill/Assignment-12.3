namespace Assignment_12._3
{
    internal class Program
    {
        static string UniqueLetters(string word)
        {
            List<char> letter = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                if (letter.Contains(word[i]))
                {
                    letter.Remove(word[i]);
                }
                else
                {
                    letter.Add(word[i]);
                }
            }

            string newWord = string.Empty;

            foreach (char c in letter)
            {
                newWord += c;
            }

            return newWord;
        }

        static void PrintResults(string word)
        {
            string result = UniqueLetters(word);
            Console.WriteLine($"{word} uniques items are {result}\n");

        }

        static void UniqueWordsResults()
        {
            string s1 = "abbaca";
            PrintResults(s1);

            string s2 = "azxxzy";
            PrintResults(s2);
        }

        static void Main(string[] args)
        {
            UniqueWordsResults();
        }
    }
}

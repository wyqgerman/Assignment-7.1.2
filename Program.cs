using System.Text;

namespace Assignment_7._1._2
{
    internal class Program
    {
        static string MergeAlternately(string word1, string word2)
        {
            StringBuilder merged = new StringBuilder();
            int i = 0, j = 0;

            while (i < word1.Length && j < word2.Length)
            {
                merged.Append(word1[i]);
                merged.Append(word2[j]);
                i++;
                j++;
            }

            if (i < word1.Length)
            {
                merged.Append(word1.Substring(i));
            }
            if (j < word2.Length)
            {
                merged.Append(word2.Substring(j));
            }

            return merged.ToString();
        }

        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine(MergeAlternately(word1, word2)); 

            word1 = "ab";
            word2 = "pqrs";
            Console.WriteLine(MergeAlternately(word1, word2)); 
        }
    }
}

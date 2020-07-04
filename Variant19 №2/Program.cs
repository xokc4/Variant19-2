using System;
using System.Linq;

namespace v19_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string eng = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Введите предложение: ");
            string s = Console.ReadLine();
            string[] sentences = s.Split('!', '.', '?');
            foreach (string sent in sentences)
            {
                string[] words = sent.Split('!', '.', '?', ';', ':', ',', ' ');

                foreach (string word in words)
                {

                    int engCount = 0;

                    for (int k = 0; k < word.Length; k++)
                    {
                        if (eng.Contains(word.ToLower()[k]))
                        {
                            engCount++;
                        }
                    }

                    if (engCount != word.Length)
                    {
                        Console.Write($"{word} ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("пока");
            Console.ReadLine();
        }
    }
}
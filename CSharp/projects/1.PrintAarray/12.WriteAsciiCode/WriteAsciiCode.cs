using System;

namespace Arrays
{
    class WriteAsciiCode
    {
        static void Main(string[] args)
        {
            char[] arrCharacter = new char[58];
            for (int i = 0; i < 58; i++)
            {
                arrCharacter[i] =(char) (65+i);
            }
            for (int i = 0; i < 58; i++)
            {
                Console.Write(arrCharacter[i]);
            }
            Console.WriteLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine(word);
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arrCharacter.Length; j++)
                {
                    if (word[i] == arrCharacter[j])
                    {
                        Console.Write(j+" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

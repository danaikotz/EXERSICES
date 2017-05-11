using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        { Badguy bad = new Badguy();
            Console.WriteLine("give the word");
            string word = Console.ReadLine();
            Console.Clear();
            char[] array = word.ToCharArray();
            char[] array2 = new char[array.Length];
            List<string> UsedLetters = new List<string>();
            for (int g = 0; g < array2.Length; g++)
            {
                if (g == 0 || g == array.Length-1)
                {
                    array2[g] = array[g]; }
                else
                {
                    array2[g] = '-';
                }
            }
            bool won = false;
            
            int count = 1;

            for (int b = 0; b <array2.Length; b++)
            {
                Console.WriteLine(array2[b]);
            }
            
            while (count < (array2.Length + 2) && !won)
            {
                Console.WriteLine(System.Environment.NewLine+"give a letter");
                var Key = Console.ReadKey(true);
                string guess = Key.KeyChar.ToString();
                bool check = false;
                
                for (int j = 0; j < array.Length; j++) {
                    if (guess == array[j].ToString())
                    {
                        array2[j] = guess[0];
                        check = true;
                    }
               
                }
           
                for(int b = 0; b < array2.Length; b++)
                {
                    Console.WriteLine(array2[b]);
                }
                if (!check && !UsedLetters.Contains(guess))
                {
                    count = count + 1;
                    bad.Throwthreats();
                    UsedLetters.Add(guess);
                }
                if (!array2.Contains('-'))
                {
                    won = true;
                }
                if (array2.Contains('-'))
                {
                    Console.WriteLine("You have" + " " + (array2.Length + 2 - count) + " " + "chances left");
                    if (UsedLetters.Count != 0)
                    {
                        Console.Write("You have already tried letters:");
                    }
                    for(int i = 0; i < UsedLetters.Count; i++)
                    {
                        Console.Write(UsedLetters[i]+"  ");
                    }
                }
            }


           
            
            if (won) {
                Console.WriteLine("you won!!!");
            }
            else {

                Console.WriteLine("you lose!!");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] check;
            int[] numbers;
            Dices Dices = new Dices();
            int dicemin = 1;
            int dicemax = 6;
            int dicenum = 2;
            int results = 0;
            int counter = 0;
            int cheat = 0;
            string play = "a";
          
                Console.WriteLine("Do you want to customize your dices? if yes press c");
                var Key = Console.ReadKey(true);
                string custom = Key.KeyChar.ToString();
            

            Console.WriteLine("ready?");
            play=Console.ReadLine();
            if (custom == "c")
            {
                Console.Write("Give min dice range");
                string diceminstr = Console.ReadLine();
                try
                {
                     dicemin = Int32.Parse(diceminstr);

                    Console.Write("Give max dice range");
                    string dicemaxstr = Console.ReadLine();

                    dicemax = Int32.Parse(dicemaxstr);
                    if (dicemax < dicemin)
                    {
                        ReportErrorToUser("max dice range must be greater than the minimum", null);
                        return;
                    }
                    Console.Write("Give number of dices");
                    string dicenumstr = Console.ReadLine();

                    dicenum = Int32.Parse(dicenumstr);
                }
                catch (FormatException e)
                {
                    ReportErrorToUser("One of the inputs where not numbers", e);
                    return;
                }
            }
            check = new int[dicemax];
            while (play != "q")
            {
                int a = dicemin;
                if (play == "o") { //one can cheat by pressing 'o' before he rolls the dices
                    a = 4;
                   
                    cheat = cheat + 1;
                }
                results = 0;
                numbers = new int[dicenum];
               
                for (int i = 1; i <= dicenum; i++)
                {
                    int rolling= Dices.ThrowDice(a, dicemax);
                    results=results+ rolling;
                    numbers[i-1] = rolling;
                    counter = counter + 1;
                    Console.WriteLine("you rolled:" + rolling);
                }
                for(int i = 0; i <= dicenum-1; i++)
                {
                    for(int j = 0; j <= dicemax-1; j++)
                    {
                        if (numbers[i] == j + 1) {
                            check[j] = check[j] + 1;
                            
                        }
                    }
                }

                
                Console.WriteLine("you rolled a sum of"+":"+results);
                Console.WriteLine("press q if you want to quit rolling");
                string Key2 = Console.ReadKey(true).KeyChar.ToString();
                play = Key2;
               if (play == "q")
                {
                    for(int i = 0; i <= dicemax - 1; i++) {
                        Console.WriteLine("you rolled" + " " + (i+1)+":" + " "+check[i]+ " "+"out of" + " " + counter+ " "+"times");
                            }
                    Console.WriteLine("You also cheated" + "  "+ cheat + "  " + "times" + "  " + "congratulations!! :D");

                    Console.ReadKey();
                }
               
            }
           
        }
        static void ReportErrorToUser(string message, Exception e)
        {
            if (e != null)
                Debug.WriteLine(e.Message);

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}

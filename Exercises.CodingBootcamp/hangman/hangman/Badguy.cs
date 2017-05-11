using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Badguy
    {
        Random R;
        List<string> threats;
        public Badguy()
        {
            threats = new List<string>();
            threats.Add("YOU ARE NEVER GOING TO MAKE IT!"); 
            threats.Add("ARE YOU EVEN TRYING?");
            threats.Add("RANDOM LETTERS WON'T HELP YOU");
            threats.Add("I WILL JUST CONTINUE DRAWING YOU....HANGED!!");
            threats.Add("COME ON! YOU ARE MAKING IT SO EASY FOR ME NOW....");

        }
        public void Throwthreats()

        {
            if (R == null)
                R = new Random();
            int threat = R.Next(0, threats.Count);
            Console.WriteLine(threats[threat]);
        }
    }
}

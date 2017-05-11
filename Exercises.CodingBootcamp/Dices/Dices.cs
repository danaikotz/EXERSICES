using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dices { 
    public Random R { get; set; }
    public int Result { get; set; }
    
        public Dices(){
        R = new Random();
        }
        public int ThrowDice(int dicemin,int dicemax) {
            Result = R.Next(dicemin, dicemax+1);
            return (Result);
        }
    }
}

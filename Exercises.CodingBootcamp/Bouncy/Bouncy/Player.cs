using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncy
{
    class Player : ISprite
    {
        public int x { get; set; }
        public int y { get; set; }

        public int vx { get; set; }
        

        public string PlayerChar { get; set; }

        public int bottom { get; set; }
        public int right { get; set; }

        private int _prevx;
        private int _prevy;
        public Player(int vx, int x, int y, string PlayerChar, int bottom, int right)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            

            this.bottom = bottom;
            this.right = right;
            this.PlayerChar = PlayerChar;

        }
        public void Draw()
        {
            Console.SetCursorPosition(_prevx, y);
            Console.Write(" ");

            //Τύπωσε την μπάλα
            Console.SetCursorPosition(x, y);
            Console.Write(PlayerChar);
        }

        public void OnInput(string s)
        {
            _prevx = x;
            _prevy = y;
            if (s == "A" && x!=0)
            {
                x = x - vx;
            }
            else if (s == "D" && x!=right)
            {
                x = x + vx;
            }
            
        }
        
        public void Update()
        {

           
        }
    }
}

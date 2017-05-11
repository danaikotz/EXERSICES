using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncy
{
    public class Ball:ISprite
    {
        public int x { get; set; }
        public int y { get; set; }

        public int vx { get; set; }
        public int vy { get; set; }

        public string BallChar { get; set; }

        public int bottom { get; set; }
        public int right { get; set; }

        private int _prevx;
        private int _prevy;

        public Ball(int vx,int vy,int x,int y ,string BallChar, int bottom, int right)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;

            this.bottom = bottom;
            this.right = right;
            this.BallChar = BallChar;

        }
        public void Update()
        {
            _prevx = x;
            _prevy = y;
            // Κούνησε την μπάλα στην επόμενη θέση
            x = x + vx;
            y = y + vy;

            // Έλεγξε αν είμαι στο όριο και αν είμαι
            // άλλαξε τη φορά της vx,vy
            if (x == 0 || x == right) vx = -vx;
            if (y == 0 || y == bottom) vy = -vy;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_prevx, _prevy);
            Console.Write(" ");

            //Τύπωσε την μπάλα
            Console.SetCursorPosition(x, y);
            Console.Write(BallChar);
        }

        public void OnInput(string k)
        {
            if (k == "B")
                vx = -vx;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncy
{
    class Program
    {
        static void Main(string[] args)
        {
            int right=20;
            int bottom=20;

            bool endloop = false;
            
            for (int i = 0; i < right+1; i++)
            {
                Console.SetCursorPosition(i, bottom+1);
                Console.Write("-");
            }
            for (int i = 0; i < bottom+1; i++)
            {
                Console.SetCursorPosition(right+1, i);
                Console.Write("|");
            }
            Ball a = new Ball(1, 1, 3, 6, "O", bottom, right);
            Ball b = new Ball(1, -1, 5, 6, "O", bottom, right);
            Ball c = new Ball(1, 1, 5, 1, "O", bottom, right);
            Player d = new Player(1, 10, 19, "A", bottom, right);
            Ball e = new Ball(1, 1, 4, 2, "O", bottom, right);
            Ball f = new Ball(1, -1, 1, 6, "O", bottom, right);
            Ball g = new Ball(1, 1, 10, 1, "O", bottom, right);
            List<ISprite> Sprites = new List<ISprite>()
            {
               a,b,c,d,e,f
                
            };

            while (!endloop)
            {
                if ((d.x == a.x && d.y == a.y) || (d.y == b.y && d.x == b.x) || (d.y == c.y && d.x == c.x) || (d.y == e.y && d.x == e.x) || (d.y == f.y && d.x == f.x))
                {
                    Console.WriteLine("Game Over");
                    endloop = true;
                }
                System.Threading.Thread.Sleep(100);
                foreach (var sprite in Sprites)
                    sprite.Update();
                foreach (var sprite in Sprites)
                    sprite.Draw();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.N )                        
                        endloop = true;
                    foreach (var sprite in Sprites)
                        sprite.OnInput(keyInfo.Key.ToString());
                }
                
            }

        }
    }
}

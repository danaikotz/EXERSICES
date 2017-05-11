using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncy
{
    interface ISprite
    {
        void Update();
        void Draw();

        void OnInput(string x);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bellring
{
    class BellRingingState : BellState
    {
        public override void Ring()
        {
            Console.WriteLine("Bell is ringing...");
        }
    }
}

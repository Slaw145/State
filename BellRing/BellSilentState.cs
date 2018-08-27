using System;
using System.Collections.Generic;
using System.Text;

namespace Bellring
{
    class BellSilentState : BellState
    {
        public override void Ring()
        {
            Console.WriteLine("Bell isn't ringing...");
        }
    }
}

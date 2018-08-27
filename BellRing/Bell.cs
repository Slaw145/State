using System;
using System.Collections.Generic;
using System.Text;

namespace Bellring
{
    class Bell
    {
        private BellState currentState;

        public Bell()
        {
            currentState = new BellRingingState();
        }

        public void setState(BellState state)
        {
            currentState = state;
        }

        public void alert()
        {
            currentState.Ring();
        }
    }
}

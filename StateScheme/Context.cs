using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    class Context
    {
        private State current;

        public void setState(State state)
        {
            current = state;
            Console.WriteLine("State: " + current.GetType().Name);
        }

        public void Request()
        {
            current.goNext(this);
        }
    }
}

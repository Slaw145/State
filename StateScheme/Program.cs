using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main()
        {
            Context c = new Context();
            c.setState(new StateOne());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }
}

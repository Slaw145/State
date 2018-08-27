using System;

namespace Bellring
{
    class Program
    {
        static void Main(string[] args)
        {
            Bell stateContext = new Bell();
            stateContext.alert();
            stateContext.alert();
            stateContext.setState(new BellSilentState());
            stateContext.alert();
            stateContext.alert();
            stateContext.alert();

            Console.ReadKey();
        }
    }
}

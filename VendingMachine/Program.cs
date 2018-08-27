using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine c = new VendingMachine();
            c.setState(new VendingDepositeState());

            c.BuyProduct(5);
            c.TakeProduct();

            c.BuyProduct(6);
            c.TakeProduct();

            c.BuyProduct(2);

            c.BuyProduct(8);
            c.TakeProduct();

            Console.ReadKey();
        }
    }
}

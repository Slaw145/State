using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    abstract class VendingMachineState
    {
        public abstract void ChangeVendingState(VendingMachine context);
        public abstract void GetProduct(int amount, VendingMachine context);
    }
}

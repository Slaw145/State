using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class VendingMachine
    {
        private VendingMachineState current;
        private int CostOfProduct;

        public void setState(VendingMachineState state)
        {
            current = state;
        }

        public void BuyProduct(int amount)
        {
            CostOfProduct = amount;
            current.GetProduct(amount, this);
        }

        public void TakeProduct()
        {
            current.GetProduct(CostOfProduct, this);
        }
    }
}

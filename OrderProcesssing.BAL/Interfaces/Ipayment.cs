using System;

namespace OrderProcesssing.BAL.Interfaces
{
    public abstract class Payment
    {
        public bool IsHavingCommision { get; set; }
        public abstract string MakePayment(Product product);

        public virtual void GetCommisionAmount(Product pro)
        {
            if (pro is Book || pro is PhysicalProduct)
            {
                IsHavingCommision = true;
                Console.WriteLine("Commision shared with agent");
            }
            else
            {
                IsHavingCommision = false;
                Console.WriteLine("No Commision for this product");
            }
        }
    }
}
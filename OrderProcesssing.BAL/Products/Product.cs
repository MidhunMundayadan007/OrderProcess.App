using System;

namespace OrderProcesssing.BAL.Interfaces
{
    public class Product 
	{
		public virtual SlipBase GenerateSlip()
		{
			Console.WriteLine("Slip Generated");
			SlipBase slipBase = new SlipBase();
			return slipBase.GetSlip();
		}
	}
}

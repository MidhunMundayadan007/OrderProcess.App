using System;

namespace OrderProcesssing.BAL.Interfaces
{
    public class PhysicalProduct : Product
	{
		public override SlipBase GenerateSlip()
		{
			
			return base.GenerateSlip(); 
		}
	}
}

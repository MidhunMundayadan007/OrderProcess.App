using System;

namespace OrderProcesssing.BAL.Interfaces
{
    public class Book : Product
	{
		public override SlipBase GenerateSlip()
		{
			var slip = base.GenerateSlip();
			DuplicateSlipDecorator decorator = new DuplicateSlipDecorator(slip);
			slip = decorator.GetSlip();
			if (slip.IsDuplicated)
			{
				Console.WriteLine(" Duplicate slip Shared with department");
			}
			return slip;
		}
	}
}

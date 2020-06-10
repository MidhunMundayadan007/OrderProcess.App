using System;

namespace OrderProcesssing.BAL.Interfaces
{
    public class Vedio : Product
	{
		public override SlipBase GenerateSlip()
		{
			var slip = base.GenerateSlip();
			AddFreeAddVedioDecorator decorator =
				new AddFreeAddVedioDecorator(slip);
			Console.WriteLine("Add on Applied" + slip.OfferDetails);
			return decorator.GetSlip();
		}
	}
}

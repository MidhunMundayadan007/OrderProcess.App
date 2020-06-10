using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssing.BAL
{

	public class AddFreeAddVedioDecorator : Decorator
	{
		public AddFreeAddVedioDecorator(SlipComponent baseComponent)
			: base(baseComponent)
		{
		}

		public override SlipBase GetSlip()
		{
			var slip = base.GetSlip();
			//This will be getting from database
			slip.OfferDetails = "Collect your free add on vedio";
			return slip;
		}
	}
}

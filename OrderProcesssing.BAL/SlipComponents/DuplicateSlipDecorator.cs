namespace OrderProcesssing.BAL
{
    public class DuplicateSlipDecorator : Decorator
	{
		public DuplicateSlipDecorator(SlipComponent baseComponent)
			: base(baseComponent)
		{
		}

		public override SlipBase GetSlip()
		{
			var slip = base.GetSlip();
			//This will be getting from database
			slip.IsDuplicated = true;
			return slip;
		}
	}
}

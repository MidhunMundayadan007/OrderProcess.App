namespace OrderProcesssing.BAL
{
    public class SlipBase : SlipComponent
	{
		public SlipBase()
		{

		}
		public string OfferDetails { get; internal set; }
		public string slip { get; internal set; }
        public bool IsDuplicated { get; internal set; }

        public override SlipBase GetSlip()
		{
			this.slip = "BaseSlip";
			return this;
		}
	}
}

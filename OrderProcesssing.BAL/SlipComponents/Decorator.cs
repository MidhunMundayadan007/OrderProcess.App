namespace OrderProcesssing.BAL
{
    public abstract class Decorator : SlipComponent
	{
		SlipComponent m_BaseComponent = null;
		protected Decorator(SlipComponent baseComponent)
		{
			m_BaseComponent = baseComponent;
		}

		public override SlipBase GetSlip()
		{
			return m_BaseComponent.GetSlip();
		}

	}
}

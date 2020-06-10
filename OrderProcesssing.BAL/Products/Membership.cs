using System;

namespace OrderProcesssing.BAL.Interfaces
{
    public class Membership : Product,IMembership
	{
		public bool CheckUserHasMemberShip()
		{
			//check this from DB
			return false;
		}
		

		public Membership()
		{
		}

		public bool ActivateMemberShip()
		{
			Console.WriteLine("Membership Activated");
			return true;
		}	

		public bool UpgradeMemberShip()
		{
			Console.WriteLine("Membership Upgraded");
			return true;
		}

		public override SlipBase GenerateSlip()
		{
			return base.GenerateSlip();
		}
	}
}

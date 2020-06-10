namespace OrderProcesssing.BAL.Interfaces
{
    interface IMembership
	{
		bool CheckUserHasMemberShip();

		bool ActivateMemberShip();
		bool UpgradeMemberShip();
	}
}

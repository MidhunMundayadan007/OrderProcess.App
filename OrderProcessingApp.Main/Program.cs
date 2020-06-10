using OrderProcesssing.BAL.Interfaces;
using System;

namespace OrderProcessingApp.Main
{
	//Base Component

	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Order Processing Application");
			Console.WriteLine("Enter the product name");
			string productName = Console.ReadLine();
			Product pro;
			if (productName=="P")
			{
				pro = new PhysicalProduct();
			}
			else if (productName == "M")
			{
				pro = new Membership();
			}
			else if (productName == "V")
			{
				pro = new Vedio();
			}
			else if (productName == "B")
			{
				pro = new Book();
			}
			else
			{
				pro = null;
			}
			 
			Payment payment = new CardPayment();

			payment.MakePayment(pro);
			payment.GetCommisionAmount(pro);


			Console.ReadKey();
		}
	}
}

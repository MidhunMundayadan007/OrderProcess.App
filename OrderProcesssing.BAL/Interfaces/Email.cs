using System;

namespace OrderProcesssing.BAL.Interfaces
{
	public class Email : IMessage
	{
		public void SendMessage(string message, string toUser)
		{
			Console.WriteLine("Email shared to user" + toUser + "regarding" + message);
		}
	}
}

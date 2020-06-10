namespace OrderProcesssing.BAL.Interfaces
{
    public interface IMessage
	{
		public void SendMessage(string message, string toUser);
	}
}

namespace Homework_008.Memento
{
	public class ClientHistory
	{
		public Stack<ClientMemento> History { get; private set; }
		public ClientHistory()
		{
			History = new Stack<ClientMemento>();
		}
	}
}

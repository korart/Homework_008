namespace Homework_008.Memento
{
	public class ClientMemento
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }

		public ClientMemento(Guid id, string name, string phone)
		{
			this.Id = id;
			this.Name = name;
			this.Phone = phone;
		}
	}
}

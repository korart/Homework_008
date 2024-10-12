using Homework_008.Memento;

namespace Homework_008.Domain
{
	public class Client
	{
		private Guid _id;
		public string Name { get; set; }
		public string Phone { get; set; }

		public Client(string name, string phone)
		{
			_id = Guid.NewGuid();
			this.Name = name;
			this.Phone = phone;
		}

		public ClientMemento SaveSate()
		{
			Console.WriteLine("Сохраняем данные клиента...");
			return new ClientMemento(_id, Name, Phone);
		}

		public void RestoreSate(ClientMemento memento)
		{
			Console.WriteLine("Восстанавливаем данные клиента...");
			this._id = memento.Id;
			this.Name = memento.Name;
			this.Phone = memento.Phone;
		}

		public override string ToString()
		{
			return $"{_id} {Name} {Phone}";
		}
	}
}

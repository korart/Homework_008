using Homework_008.Domain;
using Homework_008.Memento;
using System.Text;

namespace Homework_008
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			TaxiAgregator agregator = new();

			Console.WriteLine("Добро пожаловать на сервис заказа такси \"С ветерком!\"");
			Console.Write("Введите ваше имя: ");
			string clientName = Console.ReadLine()!;
			Console.Write("Введите ваш телефон: ");
			string clientPhone = Console.ReadLine()!;

			Client client = new(clientName, clientPhone);

			agregator.Client = client;

			Console.Write("Куда поедем? (расстояние в км.): ");
			double dist = Convert.ToDouble(Console.ReadLine());
			List<Order> offer = agregator.Request(dist);

			Console.WriteLine();
			Console.WriteLine("Найдены варианты: ");
			Console.WriteLine("1. Эконом: {0:C}", offer[0].Tax);
			Console.WriteLine("2. Бизнес: {0:C}", offer[1].Tax);
			Console.WriteLine("3. VIP:    {0:C}", offer[2].Tax);
			Console.Write("Выберите вариант 1, 2 или 3 (0 - отменить заказ): ");
			int choice = Convert.ToInt32(Console.ReadLine()) - 1;

			if (choice == -1)
			{
				return;
			}

			if (agregator.ConfirmOrder(offer[choice]))
			{
				Console.WriteLine();
				Console.WriteLine("К Вам выехал водитель: {0}, телефон: {1}", agregator.Order.TaxiCar.DiverName, agregator.Order.TaxiCar.DiverPhone);
				Console.WriteLine();
				agregator.Order.Execute();
				Console.WriteLine();
			}

			// Memento
			ClientHistory data = new ClientHistory();
			Console.WriteLine(agregator.Client);
			data.History.Push(agregator.Client.SaveSate());
			agregator.Client.Phone = "+0 000 000 00 00";
			Console.WriteLine(agregator.Client);
			agregator.Client.RestoreSate(data.History.Pop());
			Console.WriteLine(agregator.Client);

		}
	}
}

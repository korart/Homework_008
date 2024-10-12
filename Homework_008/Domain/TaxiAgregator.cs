using Homework_008.Strategy;

namespace Homework_008.Domain
{
	public class TaxiAgregator
	{
		public List<TaxiCar> Cars = new();
		public List<Client> Clients = new();
		public List<Order> ConfirmedOrders = new();

		public Client Client;
		public Order Order;

		public Tax Tax { get; set; }

		public TaxiAgregator()
		{
			Cars.AddRange([
				new TaxiCar(1, "Иванов И.И.", "+7 899 000 12 34"),
				new TaxiCar(2, "Сергеев С.С.", "+7 899 000 12 36"),
				new TaxiCar(3, "Петров П.П.", "+7 899 000 12 38"),
				]);
		}

		public List<Order> Request(double dist)
		{
			List<TaxiCar> selectedCars = new();
			selectedCars.AddRange([
				Cars.Where(c => c.Category == 1).First(),
				Cars.Where(c => c.Category == 2).First(),
				Cars.Where(c => c.Category == 3).First()
				]);

			this.Tax = StrategyFactory.GetStategy(DateTime.Now.Hour);
			
			List<Order> response = new();

			foreach (TaxiCar car in selectedCars)
			{
				response.Add(new Order(Client, car, dist, this.Tax.TotalCost(car, dist)));
			}

			return response;
		}

		public bool ConfirmOrder(Order order)
		{
			Order = order;
			ConfirmedOrders.Add(order);
			return true;
		}
	}
}

namespace Homework_008.Domain
{
	public class Order
	{
		public Guid Id { get; init; }
		public Client Client { get; init; }
		public TaxiCar TaxiCar { get; init; }
		public double Distance { get; init; }
		public decimal Tax { get; init; }

		public Order(Client client, TaxiCar taxiCar, double distance, decimal tax)
		{
			this.Id = Guid.NewGuid();
			this.Client = client;
			this.TaxiCar = taxiCar;
			this.Distance = distance;
			this.Tax = tax;
		}

		public void Execute()
		{
			Thread.Sleep(500);
			TaxiCar.UpdateState();
			Thread.Sleep(1000);
			TaxiCar.UpdateState();
			Thread.Sleep(500);
			TaxiCar.UpdateState();
		}
	}
}

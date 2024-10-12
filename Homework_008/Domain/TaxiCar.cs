using Homework_008.State;

namespace Homework_008.Domain
{
	public class TaxiCar
	{
		public Guid Id { get; init; }
		public int Category { get; init; } // 1 - Эконом, 2 - Бизнес, 3 - VIP
		public string DiverName { get; set; }
		public string DiverPhone { get; set; }

		public ITaxiState State { get; set; } = new FreeState();

		public TaxiCar(int category, string driverName, string driverPhone)
		{
			this.Id = Guid.NewGuid();
			this.Category = category;
			this.DiverName = driverName;
			this.DiverPhone = driverPhone;
		}

	}
}

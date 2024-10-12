using Homework_008.Domain;

namespace Homework_008.Strategy
{
	public abstract class Tax
	{
		protected decimal TaxPerKm;
		public decimal TotalCost(TaxiCar car, double dist)
		{
			return TaxPerKm * (decimal)car.Category * (decimal)dist + 150 * car.Category;
		}
	}
}

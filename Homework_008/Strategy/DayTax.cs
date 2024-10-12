using Homework_008.Domain;

namespace Homework_008.Strategy
{
	public class DayTax : Tax
	{
		public DayTax()
		{
			this.TaxPerKm = 8.03M;
		}
	}
}

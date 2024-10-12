using Homework_008.Domain;

namespace Homework_008.Strategy
{
	public class NightTax : Tax
	{
		public NightTax()
		{
			this.TaxPerKm = 10.00M;
		}
	}
}

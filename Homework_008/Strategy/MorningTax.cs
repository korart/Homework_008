using Homework_008.Domain;

namespace Homework_008.Strategy
{
	public class MorningTax : Tax
	{
		public MorningTax()
		{
			this.TaxPerKm = 6.75M;
		}
	}
}

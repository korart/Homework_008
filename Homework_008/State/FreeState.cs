using Homework_008.Domain;

namespace Homework_008.State
{
	public class FreeState : ITaxiState
	{
		public void Update(TaxiCar car)
		{
			Console.WriteLine("Автомобиль выехал к клиенту");
			car.State = new MoveToClientState();
		}
	}
}

using Homework_008.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_008.State
{
	internal class BusyState : ITaxiState
	{
		public void Update(TaxiCar car)
		{
			Console.WriteLine("Автомобиль освободился");
			car.State = new FreeState();
		}
	}
}

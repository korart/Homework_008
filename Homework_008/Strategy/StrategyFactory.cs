namespace Homework_008.Strategy
{
	public static class StrategyFactory
	{
		public static Tax GetStategy(int hour) => hour switch
		{
			> 20 => new NightTax(),
			> 10 => new DayTax(),
			_ => new MorningTax()
		};
	}
}

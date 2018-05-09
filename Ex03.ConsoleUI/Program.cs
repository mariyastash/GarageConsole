using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
	class Program
	{
		public static void Main()
		{
			GarageUserInputControl newGarage = new GarageUserInputControl();

			Console.WriteLine("Press 'enter' to exit.");
			Console.ReadLine();

			//Wheels carWheel = new Wheels("jiji", 123f, 333f);
			//Engine carEngine = new FuelEngine();
			//eCarColor color = eCarColor.Blue;
			//eCarDoorsAmount doors = eCarDoorsAmount.Four;

			//Vehicle c = new Car("mazda", "12345222", carWheel, carEngine, color, doors);

			//Console.WriteLine(c.ToString());
		}
	}
}

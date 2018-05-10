using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class dictEngineMaxCapacity
	{
		public Dictionary<string, float> dictFuelMaxCapacity = new Dictionary<string, float>()
		{
			{ "Regular motorcycle", 6},
			{ "Regular car", 45},
			{ "Truck", 115}
		};

		public Dictionary<string, float> dictElectricMaxCapacity = new Dictionary<string, float>()
		{
			{"Electro motorcycle", 1.8f },
			{"Electro car", 3.2f }
		};
	}
}

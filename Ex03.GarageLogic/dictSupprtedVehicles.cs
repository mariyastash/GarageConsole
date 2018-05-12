using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class dictSupprtedVehicles
	{
		public Dictionary<int, string> SupportedVehicles = new Dictionary<int, string>()
		{
			{1, "Regular motorcycle"},
			{2, "Electric motorcycle"},
			{3, "Regular car"},
			{4, "Electric car"},
			{5, "Regular truck"},
		};

		public void printDictionary()
		{
			foreach (var value in SupportedVehicles)
			{

				Console.WriteLine(value.Key.ToString() + " - " + value.Value.ToString());
			}
		}

	}
}

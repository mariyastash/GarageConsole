using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
	public class GarageUserInputControl
	{
		private Ex03.GarageLogic.GarageLogicControl m_GarageLogic;

		public GarageUserInputControl()
		{
			welcomeMessage();
			userChoiceWhatToDoNext();
		}

		private void welcomeMessage()
		{
			string msg = string.Format(
@"Welcome to the Garage!
Now you can choose what to do next");
			Console.WriteLine(msg);
			Console.WriteLine();
		}

		private void userChoiceWhatToDoNext()
		{
			string msg = string.Format(
@"*To add a new vehicle to the garage, please enter 1.
*To see the license numbers of vehicles in the garage, please enter 2.
*To change status of any car in the garage, please enter 3.
*To add air to the wheels of any vehicle, please enter 4.
*To add fuel to any car with fuel engine, please enter 5.
*To charge any electric vehicle, please enter 6.
*to see all details of any vehecle, please enter 7.");

			Console.WriteLine(msg);
			Console.WriteLine();
		}
    }
}

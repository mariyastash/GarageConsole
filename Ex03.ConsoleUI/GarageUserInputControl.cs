using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
	public class GarageUserInputControl
	{
		private GarageLogicControl m_GarageLogic;
		private int userChosenAction; /////////////////////////
		private VehicleOwner m_Owner;

		public VehicleOwner Owner
		{
			get { return m_Owner; }
			set { m_Owner = value; }
		}

		public GarageUserInputControl()
		{
			welcomeMessage();
			userChoiceWhatToDoNext();
			navigationToUserChosenMethod(userChosenAction);
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
			string stringUserChocenInput;
			bool validInput = false;
            string msg = string.Format(
@"*Enter 1: To add a new vehicle to the garage.
*Enter 2: To see the list of vehicles in the garage.
*Enter 3: To change status of any car in the garage.
*Enter 4: To add air to the wheels of any vehicle.
*Enter 5: To add fuel to any car with fuel engine.
*Enter 6: To charge any electric vehicle.
*Enter 7: to see all details of any vehecle.");

			Console.WriteLine(msg);

			try
			{
				do
				{
					Console.WriteLine("The system is waiting for your selection...:");
					stringUserChocenInput = Console.ReadLine();
					validInput = int.TryParse(stringUserChocenInput, out userChosenAction);
					if (userChosenAction < 1 || userChosenAction > 7)
					{
						validInput = false;
					}
					if (!validInput)
					{
						Console.WriteLine("invalid input");
					}
				}
				while (!validInput);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void navigationToUserChosenMethod(int i_userChosenAction)
		{
			switch (i_userChosenAction)
			{
				case 1:
					inputForNewVehicleInGarage();
					break;
				case 2:
					////
					break;
				case 3:
					////
					break;
				case 4:
					////
					break;
				case 5:
					////
					break;
				case 6:
					////
					Console.WriteLine("six");
					break;
				case 7:
					////
					break;
				default:
					break;
			}
		}

		private void inputForNewVehicleInGarage()
		{
			//string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, eCarColor i_Color, eCarDoorsAmount i_DoorsAmount, VehicleOwner 
			string ownerName, ownerPhoneNumber;

			Console.WriteLine("Please enter vehicle owner data:");
			Console.WriteLine("Owner Name:");
			ownerName = Console.ReadLine();
			Console.WriteLine("Owner phone number:");
			ownerPhoneNumber = Console.ReadLine();

			m_Owner = new VehicleOwner(ownerName, ownerPhoneNumber);

			Console.WriteLine(m_Owner.ToString());



		}
	}
}

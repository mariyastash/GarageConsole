using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
	public class GarageUserInputControl
	{
		private GarageLogicControl m_GarageLogic = new GarageLogicControl();
		private NewVehicleCreature m_NewVehicleCreature = new NewVehicleCreature();
		private int userChosenAction; /////////////////////////
		private VehicleOwner m_Owner;
		private Stack<string> m_StandatrVehicleStringParams = new Stack<string>();
		private Stack<float> m_StandatrVehicleFloatParams = new Stack<float>();
		private Vehicle m_Vehicle;
		private eFuelType m_FuelType;
	
		
		private Wheels m_wheel;

		public Wheels Wheel
		{
			get { return m_wheel; }
			set { m_wheel = value; }
		}

		public eFuelType FuelType
		{
			get { return m_FuelType; }
			set { m_FuelType = value; }
		}

		public Vehicle vehicle
		{
			get { return m_Vehicle; }
			set { m_Vehicle = value; }
		}

		public Stack<string> StandartVehicleStringParams //brand name, registration plate
		{
			get { return m_StandatrVehicleStringParams; }
			set { m_StandatrVehicleStringParams = value; }
		}

		public Stack<float> StandartVehicleFloatParams //energy percent, wheels psi
		{
			get { return m_StandatrVehicleFloatParams; }
			set { m_StandatrVehicleFloatParams = value; }
		}

		public VehicleOwner Owner
		{
			get { return m_Owner; }
			set { m_Owner = value; }
		}

		public GarageUserInputControl()
		{
			welcomeMessage();
			do
			{
				userChoice();
				navigationToUserChosenMethod(userChosenAction);
			}
			while (userChosenAction != 0);
        }

		private void welcomeMessage()
		{
			string msg = string.Format(
@"Welcome to the Garage!
Now you can choose what to do next");
			Console.WriteLine(msg);
			Console.WriteLine();
        }

		private void userChoice()
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
*Enter 7: To see all details of any vehecle.
Enter 0: To exit.");

			Console.WriteLine(msg);

			try
			{
				do
				{
					Console.WriteLine("The system is waiting for your selection...:");
					stringUserChocenInput = Console.ReadLine();
					validInput = int.TryParse(stringUserChocenInput, out userChosenAction);
					if (userChosenAction < 0 || userChosenAction > 7)
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
					inputForNewOwnerInGarage();
					inputForNewVehicleInGarage();
					break;
				case 2:
					ShowAllVehiclesInGarage();
					break;
				case 3:
					changeVehicleStatus();
					break;
				case 4:
					fillAirToMaximum();
					break;
				case 5:
					
					break;
				case 6:
					rechargeElectricVehicle();
					break;
				case 7:
					showAllVehicleInfo();
                    break;
				default:
					break;
			}
		}

		private void inputForNewOwnerInGarage()
		{
			string ownerName, ownerPhoneNumber;

			Console.WriteLine("Please enter vehicle owner data:");
			Console.WriteLine("Owner Name:");
			ownerName = Console.ReadLine();
			Console.WriteLine("Owner phone number:");
			ownerPhoneNumber = Console.ReadLine();

			m_Owner = new VehicleOwner(ownerName, ownerPhoneNumber);
		}

		public void inputForNewVehicleInGarage()
		{
			bool validInput = false;
			int choicenVehicle = 0;
			string wheelsBrand;
			string vehicleType;
			
			string msg = string.Format(
@"Please enter Vehicle kind:
You can choice from supported vehicles list: 
");
			Console.WriteLine(msg);
			m_GarageLogic.SupportedVehiclesList.printDictionary();
			validInput = int.TryParse(Console.ReadLine(), out choicenVehicle);

			InputStandartVehicleParams();
			wheelsBrand = InputWheelsVehicleParams();

			//Motorcycle
			string motoDriverLicense = null;
			int engineCapaciyInCC = 0;
			//Car
			string carColor = null;
			int carDoorsAmout = 0;
			//Truck
			bool truckIsCooled = false;
			float truckCapacity = 0;

			m_NewVehicleCreature.PopStandartVehicleParams(StandartVehicleStringParams, StandartVehicleFloatParams);	

			switch (choicenVehicle)
			{
				case 1:
					FuelType = eFuelType.Octan96;
					validInput = m_GarageLogic.SupportedVehiclesList.SupportedVehicles.TryGetValue(choicenVehicle, out vehicleType);

					inputForMotorcycle(ref motoDriverLicense, ref engineCapaciyInCC);
					m_NewVehicleCreature.CreateNewEngine(vehicleType, FuelType);
					m_Vehicle = m_NewVehicleCreature.CreateNewMotorcycleInGarage(Owner, wheelsBrand, motoDriverLicense, engineCapaciyInCC);
					m_GarageLogic.AddNewVehicleToGarage(m_Vehicle);
					break;

				case 2:
					FuelType = eFuelType.Electricity;
					validInput = m_GarageLogic.SupportedVehiclesList.SupportedVehicles.TryGetValue(choicenVehicle, out vehicleType);

					inputForMotorcycle(ref motoDriverLicense, ref engineCapaciyInCC);
					m_NewVehicleCreature.CreateNewEngine(vehicleType, FuelType);
					m_Vehicle = m_NewVehicleCreature.CreateNewMotorcycleInGarage(Owner, wheelsBrand, motoDriverLicense, engineCapaciyInCC);
					m_GarageLogic.AddNewVehicleToGarage(m_Vehicle);
					break;

				case 3:
					FuelType = eFuelType.Octan98;
					validInput = m_GarageLogic.SupportedVehiclesList.SupportedVehicles.TryGetValue(choicenVehicle, out vehicleType);

					inputForCar(ref carColor, ref carDoorsAmout);
					m_NewVehicleCreature.CreateNewEngine(vehicleType, FuelType);
					m_Vehicle = m_NewVehicleCreature.CreateNewCarInGarage(Owner, wheelsBrand, carColor, carDoorsAmout);
					m_GarageLogic.AddNewVehicleToGarage(m_Vehicle);
					break;
				case 4:
					FuelType = eFuelType.Electricity;
					validInput = m_GarageLogic.SupportedVehiclesList.SupportedVehicles.TryGetValue(choicenVehicle, out vehicleType);

					inputForCar(ref carColor, ref carDoorsAmout);
					m_NewVehicleCreature.CreateNewEngine(vehicleType, FuelType);
					m_Vehicle = m_NewVehicleCreature.CreateNewCarInGarage(Owner, wheelsBrand, carColor, carDoorsAmout);
					m_GarageLogic.AddNewVehicleToGarage(m_Vehicle);
					break;

				case 5:
					FuelType = eFuelType.Soler;
					validInput = m_GarageLogic.SupportedVehiclesList.SupportedVehicles.TryGetValue(choicenVehicle, out vehicleType);

					InputForTruck(ref truckIsCooled, ref truckCapacity);
					m_NewVehicleCreature.CreateNewEngine(vehicleType, FuelType);
					m_Vehicle = m_NewVehicleCreature.CreateNewTruckInGarage(Owner, wheelsBrand, truckIsCooled, truckCapacity);
					m_GarageLogic.AddNewVehicleToGarage(m_Vehicle);
					break;

				default:
					Console.WriteLine("invalid input");
					break;
			}
		}

		public void InputStandartVehicleParams()
		{
			bool validInput = false;
			float currentEnergyPercent, currentWheelsPSI;

			Console.WriteLine("Enter vehicle brand: ");
			StandartVehicleStringParams.Push(Console.ReadLine());

			Console.WriteLine("Enter registration plate:");
			StandartVehicleStringParams.Push(Console.ReadLine());

			Console.WriteLine("Enter current energy capacity in percent: ");
			validInput = float.TryParse(Console.ReadLine(), out currentEnergyPercent);
			StandartVehicleFloatParams.Push(currentEnergyPercent);

			Console.WriteLine("Please enter current wheels PSI");
			validInput = float.TryParse(Console.ReadLine(), out currentWheelsPSI);
			StandartVehicleFloatParams.Push(currentWheelsPSI);
        }

		public void inputForMotorcycle(ref string i_driverLicense, ref int i_engineVolumeInCC)
		{
			bool isValidInput = false;

			Console.WriteLine("Please enter Motorcycle drive license:");
			i_driverLicense = Console.ReadLine();
			foreach (eMotoDriverLicense license in Enum.GetValues(typeof(eMotoDriverLicense)))
			{
				if (i_driverLicense == license.ToString())
				{
					isValidInput = true;
				}
			}

			Console.WriteLine("Please enter Engine volume in cc:");
			isValidInput = int.TryParse(Console.ReadLine(), out i_engineVolumeInCC);
        }

		public void inputForCar(ref string i_Color, ref int i_DoorsAmount)
		{
			bool isValidInput = false;

			Console.WriteLine("Please enter car color:");
			i_Color = Console.ReadLine();

			foreach (eCarColor color in Enum.GetValues(typeof(eCarColor)))
			{
				if (i_Color == color.ToString())
				{
					isValidInput = true;
				}
			}
			Console.WriteLine("Please enter doors amount");
			isValidInput = int.TryParse(Console.ReadLine(), out i_DoorsAmount);
		}

		public void InputForTruck(ref bool i_TruckIsCooled, ref float i_TruckCapacity)
		{
			bool isValidInput = false;
			string booleanStringIfTruckIsCooled;

			Console.WriteLine("Please enter Y if the truck is cooled or N if it doesn't:");
			booleanStringIfTruckIsCooled = Console.ReadLine();

			if (booleanStringIfTruckIsCooled == "Y")
			{
				i_TruckIsCooled = true;
            }

			Console.WriteLine("Please enter truck capacity");
			isValidInput = float.TryParse(Console.ReadLine(), out i_TruckCapacity);
		}

		public string InputWheelsVehicleParams()
		{
			string wheelsBrand;

			Console.WriteLine("Please enter wheels brand:");
			wheelsBrand = Console.ReadLine();
			return wheelsBrand;

		}

		public void ShowAllVehiclesInGarage()
		{
			string userStringSelection;
			int userSelection;
			bool validInput = false;
			Console.WriteLine(string.Format(
@"Please Choose what state of vehicles you want to see:
1 : All vehicle in garage.
2 : {0}.
3 : {1}.
4 : {2}.
", eVehicleStatus.InTheAmendment, eVehicleStatus.Fixed, eVehicleStatus.PaidUp));

			userStringSelection = Console.ReadLine();
			validInput = int.TryParse(userStringSelection, out userSelection);
            Console.Clear();

			Console.WriteLine("List of vehicles:");
			if (userSelection == 1)
			{
				foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
				{
					string plate = veh.VehicleRegistrationPlate;
					Console.WriteLine(plate);
				}
			}

			else
			{
				foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
				{
					if (veh.m_Status == (eVehicleStatus)userSelection)
					{
						string plate = veh.VehicleRegistrationPlate;
						Console.WriteLine(plate);
					}
				}
			}
		} //2

		private void changeVehicleStatus()
		{
			string choicenVehicleRegistrationPlate, userStringSelection;
			bool validInput = false;
			int userSelection;
            Console.WriteLine("Please choice vehicle registration plate to change vehicle status:");
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				Console.WriteLine(veh.VehicleRegistrationPlate);
			}

			choicenVehicleRegistrationPlate = Console.ReadLine();
			Console.WriteLine(string.Format(
@"Please select new status:
1 : Do not change.
2 : {0}.
3 : {1}.
4 : {2}.
", eVehicleStatus.InTheAmendment, eVehicleStatus.Fixed, eVehicleStatus.PaidUp));

			userStringSelection = Console.ReadLine();
			validInput = int.TryParse(userStringSelection, out userSelection);

			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				if (veh.VehicleRegistrationPlate == choicenVehicleRegistrationPlate)
				{
					veh.VehivleStatus = (eVehicleStatus)userSelection;
                }
			}
		} //3

		private void fillAirToMaximum()
		{
			string choicenVehicleRegistrationPlate;

            Console.WriteLine("Please choice vehicle registration plate to fill air:");
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				Console.WriteLine(veh.VehicleRegistrationPlate);
			}

			choicenVehicleRegistrationPlate = Console.ReadLine();
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				if (veh.VehicleRegistrationPlate == choicenVehicleRegistrationPlate)
				{
					veh.VehicleWheel.FillAir(); 
				}
			}
		} //4

		private void rechargeElectricVehicle()
		{
			string choicenVehicleRegistrationPlate, userChoiceMinutsToAdd;
			float hoursToAdd;
			bool validInput;

			Console.WriteLine("Please choice electric vehicle registration plate to recharge engine:");
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				if (typeof(ElectricEngine).IsAssignableFrom(veh.VehicleEngine.GetType()))
				{
					Console.WriteLine(veh.VehicleRegistrationPlate);
				}
				else
				{
					Console.WriteLine("No electric vehicles in garage.");
				}
			}

			choicenVehicleRegistrationPlate = Console.ReadLine();
			Console.WriteLine("Enter minuts to add:");
			userChoiceMinutsToAdd = Console.ReadLine();
			validInput = float.TryParse(userChoiceMinutsToAdd, out hoursToAdd);
			hoursToAdd /= 60;
            foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				if (veh.VehicleRegistrationPlate == choicenVehicleRegistrationPlate)
				{
					veh.VehicleEngine.AddEnergy(hoursToAdd);
				}
			}
		} //6

		private void addFuelToVehicle()
		{
			string choicenVehicleRegistrationPlate, userChoiceLiterToAdd;
			float litersToAdd;
			bool validInput;

			Console.WriteLine("Please choice fuel vehicle registration plate to add fuel:");
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				if (typeof(FuelEngine).IsAssignableFrom(veh.VehicleEngine.GetType()))
				{
					Console.WriteLine(veh.VehicleRegistrationPlate);
				}
				else
				{
					Console.WriteLine("No fuel vehicles in garage.");
				}
			}

			choicenVehicleRegistrationPlate = Console.ReadLine();
			Console.WriteLine("Enter liters to add:");
			userChoiceLiterToAdd = Console.ReadLine();
			validInput = float.TryParse(userChoiceLiterToAdd, out litersToAdd);
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				if (veh.VehicleRegistrationPlate == choicenVehicleRegistrationPlate)
				{
					veh.VehicleEngine.AddEnergy(litersToAdd);
				}
			}
		} //5

		private void showAllVehicleInfo()
		{
			string choicenVehicleRegistrationPlate;
		//	bool validInput;
			string vehicleFullyInfo;

			Console.WriteLine("Please choice vehicle registration plate from garage:");
			foreach (var veh in m_GarageLogic.m_VehiclesInGarage)
			{
				Console.WriteLine(veh.VehicleRegistrationPlate);
			}

			choicenVehicleRegistrationPlate = Console.ReadLine();
			vehicleFullyInfo = m_GarageLogic.DisplayVehicleFullyInfo(choicenVehicleRegistrationPlate);

			Console.WriteLine(vehicleFullyInfo + Owner.ToString());
			Console.WriteLine("To continue press any key...");
			Console.ReadLine();
		}
	}
}

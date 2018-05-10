using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class NewVehicleCreature
	{
		private GarageLogicControl m_GarageLogicControl = new GarageLogicControl();
		private Vehicle m_Vehicle;
		private Wheels m_Wheels;
		private dictEngineMaxCapacity m_EnergyMaxCapacity = new dictEngineMaxCapacity();
		Engine m_VehicleEngine;
		string vehicleBrandName, vehicleRegistrationPlate;
		float m_CurrentEnergyCapacity, m_CurrentWheelPSI;

		public Engine VehicleEngine
		{
			get { return m_VehicleEngine; }
			set { m_VehicleEngine = value; }
		}

		public dictEngineMaxCapacity EnergyMaxCapacity
		{
			get { return m_EnergyMaxCapacity; }
			set { m_EnergyMaxCapacity = value; }
		}

		public Wheels Wheel
		{
			get { return m_Wheels; }
			set { m_Wheels = value; }
		}

		public Vehicle vehicle
		{
			get { return m_Vehicle; }
			set { m_Vehicle = value; }
		}

		public void PopStandartVehicleParams(Stack<string> i_StandartVehicleStringParams, Stack<float> i_StandartVehicleFloatParams)
		{
			vehicleRegistrationPlate = i_StandartVehicleStringParams.Pop(); //vehicle Registration Plate
			vehicleBrandName = i_StandartVehicleStringParams.Pop(); //vehicle Brand Name
			m_CurrentEnergyCapacity = i_StandartVehicleFloatParams.Pop();
			m_CurrentWheelPSI = i_StandartVehicleFloatParams.Pop();

		}

		public void CreateNewEngine(string i_VehicleType, eFuelType i_FuelType)
		{
			bool existValue = false;
			float maxEnergyCapacity = 0;

			if (i_VehicleType == "Regular motorcycle" || i_VehicleType == "Regular car" || i_VehicleType == "Truck") //Fuel engine
			{
				existValue = EnergyMaxCapacity.dictFuelMaxCapacity.TryGetValue(i_VehicleType, out maxEnergyCapacity); //max Fuel Capacity
				VehicleEngine = new FuelEngine(i_FuelType, maxEnergyCapacity, m_CurrentEnergyCapacity, i_VehicleType); //Vehicle Engine
			}
			else if(i_VehicleType == "Electric motorcycle" || i_VehicleType == "Electric car") //Electric engine
			{
				existValue = EnergyMaxCapacity.dictElectricMaxCapacity.TryGetValue(i_VehicleType, out maxEnergyCapacity); //max Fuel Capacity
				VehicleEngine = new ElectricEngine(maxEnergyCapacity, m_CurrentEnergyCapacity, i_VehicleType); //Vehicle Engine
			}
		}

		public void CreateNewMotorcycleInGarage(VehicleOwner i_Owner, string i_WheelsBrand, string i_MotoDriverLicense, int i_EngineCapaciyInCC)
		{
			string wheelsBrand = i_WheelsBrand;
			
            eMotoDriverLicense driverLicense = (eMotoDriverLicense)Enum.Parse(typeof(eMotoDriverLicense), i_MotoDriverLicense);

			Wheel = new Wheels(wheelsBrand, m_CurrentWheelPSI, eMaxWheelPSI.Motorcycle, eVehicleWheelsAmount.Two);
			vehicle = new Motorcycle(vehicleBrandName, vehicleRegistrationPlate, Wheel, VehicleEngine, driverLicense, i_Owner, i_EngineCapaciyInCC);
			m_GarageLogicControl.AddNewVehicleToGarage(vehicle);
		}

		public void CreateNewCarInGarage(VehicleOwner i_Owner, string i_WheelsBrand, string i_Color, int i_DoorsAmount)
		{
			string wheelsBrand = i_WheelsBrand;

			eCarColor carColor = (eCarColor)Enum.Parse(typeof(eCarColor), i_Color);
			eCarDoorsAmount carDoorsAmount = (eCarDoorsAmount)i_DoorsAmount;
			
			Wheel = new Wheels(wheelsBrand, m_CurrentWheelPSI, eMaxWheelPSI.Car, eVehicleWheelsAmount.Four);
			vehicle = new Car(vehicleBrandName, vehicleRegistrationPlate, Wheel, VehicleEngine, carColor, carDoorsAmount, i_Owner);
			m_GarageLogicControl.AddNewVehicleToGarage(vehicle);
		}

		public void CreateNewTruckInGarage(VehicleOwner i_Owner, string i_WheelsBrand, bool i_TruckIsCooled, float i_TruckCapacity)
		{
			string wheelsBrand = i_WheelsBrand;

			Wheel = new Wheels(wheelsBrand, m_CurrentWheelPSI, eMaxWheelPSI.Car, eVehicleWheelsAmount.Twelve);
			vehicle = new Truck(vehicleBrandName, vehicleRegistrationPlate, Wheel, VehicleEngine, i_TruckIsCooled, i_TruckCapacity, i_Owner);
			m_GarageLogicControl.AddNewVehicleToGarage(vehicle);
		}
    }
}

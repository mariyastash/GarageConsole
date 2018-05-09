using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class Car : Vehicle
	{
		private eCarColor m_Color;
		private eCarDoorsAmount m_DoorsAmount;
		private readonly eVehicleWheelsAmount m_CarWheelsAmount = eVehicleWheelsAmount.Four;
		private readonly eMaxWheelPSI m_CarWheelMaxPSI = eMaxWheelPSI.Car;
		private readonly dictEngineMaxCapacity m_EngineMaxCapacity;


		public Car(string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, eCarColor i_Color, eCarDoorsAmount i_DoorsAmount, VehicleOwner i_VehicleOwner) 
			:base(i_VehicleBrand, i_VehicleRegistrationPlate, i_Wheels, i_Engine, i_VehicleOwner)
		{
			m_Color = i_Color;
			m_DoorsAmount = i_DoorsAmount;
        }

		public eCarColor CarColor
		{
			get { return m_Color; }
			set { m_Color = value; }
		}

		public eCarDoorsAmount CarDoorsAmount
		{
			get { return m_DoorsAmount; }
			set { m_DoorsAmount = value; }
		}

		public eVehicleWheelsAmount VehicleWheelsAmount
		{
			get { return m_CarWheelsAmount; }
		}

		public dictEngineMaxCapacity EngineMaxCapacity
		{
			get { return m_EngineMaxCapacity; }
		}
	}
}

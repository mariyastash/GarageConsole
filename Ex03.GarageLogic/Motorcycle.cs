using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class Motorcycle : Vehicle
	{
		private eMotoDriverLicense m_MotoDriverLicense;
		private readonly eVehicleWheelsAmount m_MotoWheelsAmount = eVehicleWheelsAmount.Two;
		private readonly eMaxWheelPSI m_MotoWheelMaxPSI = eMaxWheelPSI.Motorcycle;


		public Motorcycle(string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, eMotoDriverLicense i_MotoDriverLicense, VehicleOwner i_VehicleOwner)
			: base(i_VehicleBrand, i_VehicleRegistrationPlate, i_Wheels, i_Engine, i_VehicleOwner)
		{
			m_MotoDriverLicense = i_MotoDriverLicense;
        }

		public eMotoDriverLicense MotoDriverLicense
		{
			get { return m_MotoDriverLicense; }
			set { m_MotoDriverLicense = value; }
		}
	}
}

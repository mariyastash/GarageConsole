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
		private int m_EngineVolumeInCC;

		public int EngineVolumeInCC
		{
			get { return m_EngineVolumeInCC; }
			set { m_EngineVolumeInCC = value; }
		}

		public Motorcycle(string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, eMotoDriverLicense i_MotoDriverLicense, VehicleOwner i_VehicleOwner,int i_EngineVolumeInCC)
			: base(i_VehicleBrand, i_VehicleRegistrationPlate, i_Wheels, i_Engine, i_VehicleOwner)
		{
			m_MotoDriverLicense = i_MotoDriverLicense;
			m_EngineVolumeInCC = i_EngineVolumeInCC;
        }

		public eMotoDriverLicense MotoDriverLicense
		{
			get { return m_MotoDriverLicense; }
			set { m_MotoDriverLicense = value; }
		}
	}
}

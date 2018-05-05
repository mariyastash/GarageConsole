using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public abstract class Vehicle
	{
		#region Members and Props
		#region Members
		private string m_VehicleBrand;
		private string m_VehicleRegistrationPlate;
		private float m_EnergyPercent;
		Wheels m_Wheels;
		private eVehicleStatus m_Status;

		#endregion Members

		#region Props
		public string VehicleBrand
		{
			get { return m_VehicleBrand; }
			set { m_VehicleBrand = value; }
		}

		public string VehicleRegistrationPlate
		{
			get { return m_VehicleRegistrationPlate; }
			set { m_VehicleRegistrationPlate = value; }
		}

		public float EnergyPercent
		{
			get { return m_EnergyPercent; }
			set { m_EnergyPercent = value; }
		}

		public eVehicleStatus VehivleStatus
		{
			get { return m_Status; }
			set { m_Status = value}
		}

		#endregion Props
		#endregion Members and Props

		#region Methods
		public abstract void AddAir();
		#endregion Methods
	}
}

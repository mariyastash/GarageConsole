using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class GarageLogicControl
	{
		private dictSupprtedVehicles m_dictSupportedVehicles = new dictSupprtedVehicles();

		public List<Vehicle> m_VehiclesInGarage = new List<Vehicle>();

		public List<Vehicle> VehiclesInGarage
		{
			get { return m_VehiclesInGarage; }
			set { m_VehiclesInGarage = value; }
		}

		public dictSupprtedVehicles SupportedVehiclesList
		{
			get { return m_dictSupportedVehicles; }
			set { m_dictSupportedVehicles = value; }
		}

		public void AddNewVehicleToGarage(Vehicle i_Vehicle)
		{
			m_VehiclesInGarage.Add(i_Vehicle);
			Console.WriteLine(m_VehiclesInGarage.Count);
        }

		public string DisplayVehicleFullyInfo(string i_RegistrationPlate)
		{
			foreach (Vehicle veh in m_VehiclesInGarage)
			{
				if (veh.m_VehicleRegistrationPlate == i_RegistrationPlate)
				{
					return veh.ToString();
                }
			}
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class GarageLogicControl
	{
		////Owner name, owner telephone, vehicle status

		public List<string> m_SupportedVehiclesList = new List<string>();
		public List<Vehicle> m_VehiclesInGarage = new List<Vehicle>();

		public List<string> SupportedVehiclesList
		{
			get { return m_SupportedVehiclesList; }
			set { m_SupportedVehiclesList = value; }
		}

		public void AddToSupportedVehicleList(string i_VehicleToAddToSupportedList)
		{
			m_SupportedVehiclesList.Add(i_VehicleToAddToSupportedList);
		}

		public void PrintList()
		{
			foreach (string vehicle in m_SupportedVehiclesList)
			{
				Console.WriteLine(vehicle);
			}
		}


		public void AddNewVehicleToGarage(Vehicle i_Vehicle)
		{
			m_VehiclesInGarage.Add(i_Vehicle);
		}

		public void ShowAllVehiclesInGarage()
		{
			
		}
	}
}

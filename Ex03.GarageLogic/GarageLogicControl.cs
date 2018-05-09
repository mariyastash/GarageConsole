using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class GarageLogicControl
	{
		////Owner name, owner telephone, vehicle status

		public List<string> m_SupportedVehiclesList = new List<string>();

		public void AddToSupportedVehicleList(string i_VehicleToAddToSupportedList)
		{
			m_SupportedVehiclesList.Add(i_VehicleToAddToSupportedList);
		}

	}
}

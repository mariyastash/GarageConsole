using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class Truck : Vehicle
	{
		private bool m_TrunkIsCooled;
		private float m_TrunkCapacity;
		private readonly eVehicleWheelsAmount m_TrunkWheelsAmount = eVehicleWheelsAmount.Twelve;
		private readonly eMaxWheelPSI m_TruckWheelMaxPSI = eMaxWheelPSI.Truck;

		public Truck(string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, bool i_TrunkIsCooled, float i_TrunkCapacity, VehicleOwner i_VehicleOwner)
			: base(i_VehicleBrand, i_VehicleRegistrationPlate, i_Wheels, i_Engine, i_VehicleOwner)
		{
			m_TrunkIsCooled = i_TrunkIsCooled;
			m_TrunkCapacity = i_TrunkCapacity;
        }

		public float TrunkCapacity
		{
			get { return m_TrunkCapacity; }
			set { m_TrunkCapacity = value; }
		}

		public bool TrunkIsCooled
		{
			get { return m_TrunkIsCooled; }
			set { m_TrunkIsCooled = value; }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class Truck : Vehicle
	{
		private bool m_TruckIsCooled;
		private float m_TruckCapacity;
		private readonly eVehicleWheelsAmount m_TrunkWheelsAmount = eVehicleWheelsAmount.Twelve;
		private readonly eMaxWheelPSI m_TruckWheelMaxPSI = eMaxWheelPSI.Truck;

		public Truck(string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, bool i_TrunkIsCooled, float i_TrunkCapacity, VehicleOwner i_VehicleOwner)
			: base(i_VehicleBrand, i_VehicleRegistrationPlate, i_Wheels, i_Engine, i_VehicleOwner)
		{
			m_TruckIsCooled = i_TrunkIsCooled;
			m_TruckCapacity = i_TrunkCapacity;
        }

		public float TruckCapacity
		{
			get { return m_TruckCapacity; }
			set { m_TruckCapacity = value; }
		}

		public bool TruckIsCooled
		{
			get { return m_TruckIsCooled; }
			set { m_TruckIsCooled = value; }
		}

		public override string ToString()
		{
			string TruckInfo;

			TruckInfo = string.Format(
@"Is the truck carring dangerouse material: {0}
The truck capacity: {1}
",
TruckIsCooled,
TruckCapacity);
			return base.ToString() + TruckInfo;
		}
	}
}

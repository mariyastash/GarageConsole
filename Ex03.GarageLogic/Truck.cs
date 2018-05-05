using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public abstract class Truck : Vehicle
	{
		private bool m_TrunkIsCooled;
		private float m_TrunkCapacity;

		public float TrunkCapacity
		{
			get { return m_TrunkCapacity; }
			set { m_TrunkCapacity = value; }
		}
	}
}

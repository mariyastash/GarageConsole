using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public abstract class Motorcycle : Vehicle
	{
		private eMotoDriverLicense m_MotoDriverLicense;
		private int m_EnergyCapacity;

		

		public eMotoDriverLicense MotoDriverLicense
		{
			get { return m_MotoDriverLicense; }
			set { m_MotoDriverLicense = value; }
		}

		public int EnergyCapacity
		{
			get { return m_EnergyCapacity; }
			set { m_EnergyCapacity = value; }
		}
	}
}

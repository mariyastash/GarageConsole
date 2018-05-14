using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class Wheels
	{
		private readonly string m_BrandName;
		private float m_CurrentPSI;
		private eMaxWheelPSI m_MaxPSI;
        private eVehicleWheelsAmount m_AmountOfWheels;

        public Wheels(string i_BrandName, float i_CurrentPSI, eMaxWheelPSI i_MaxPSI, eVehicleWheelsAmount i_VehicleWheelsAmount)
		{
			m_BrandName = i_BrandName;
			m_CurrentPSI = i_CurrentPSI;
			m_MaxPSI = i_MaxPSI;
            m_AmountOfWheels = i_VehicleWheelsAmount;
        }

		public string WheelsBrandName
		{
			get { return m_BrandName; }
		}

		public float WheelsCurrentPSI
		{
			get { return m_CurrentPSI; }
			set { m_CurrentPSI = value; }
		}

		public eMaxWheelPSI WheelMaxPSI
		{
			get { return m_MaxPSI; }
			set { m_MaxPSI = value; }
		}

        public eVehicleWheelsAmount NumberOfWheels
        {
            get { return m_AmountOfWheels; }
            set { m_AmountOfWheels = value; }
        }

        public void FillAir()
		{
			WheelsCurrentPSI = (float)WheelMaxPSI;
		}

		public override string ToString()
		{
			string wheelInfo;

			wheelInfo = string.Format(
@"Brand wheels name is: {0}
Number of Wheels: {1}
The max air PSI is: {2}
Current air pressure is: {3}",
WheelsBrandName,
(int)NumberOfWheels,
(int)WheelMaxPSI,
WheelsCurrentPSI);

			return wheelInfo;
		}
	}
}

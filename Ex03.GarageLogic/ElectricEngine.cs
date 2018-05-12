using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class ElectricEngine : Engine
	{
		private float m_MaxHoursCapacity;
		private float m_CurrentHoursCapacity;
		private readonly dictEngineMaxCapacity m_dictElectricMaxCapacity;

		public ElectricEngine(float i_CurrentHoursCapacity, float i_MaxEnergyCapacity, string i_VehicleType)
		{
			m_dictElectricMaxCapacity = new dictEngineMaxCapacity();
			m_dictElectricMaxCapacity.dictElectricMaxCapacity.TryGetValue(i_VehicleType, out m_MaxHoursCapacity);
            m_CurrentHoursCapacity = i_CurrentHoursCapacity;
		}

		public float MaxCapacity
		{
			get { return m_MaxHoursCapacity; }
		}

		public float MaxHoursCapacity
		{
			get { return m_MaxHoursCapacity; }
			set { m_MaxHoursCapacity = value; }
		}

		public float CurrentHoursCapacity
		{
			get { return m_CurrentHoursCapacity; }
			set { m_CurrentHoursCapacity = value; }
		}
		
		public override void AddEnergy(float i_HoursAmountToAdd)
		{
			CurrentHoursCapacity += i_HoursAmountToAdd;

			if (CurrentHoursCapacity > MaxHoursCapacity)
			{
				CurrentHoursCapacity = MaxHoursCapacity;
            }
        }

		public override string ToString()
		{
			string EngineInfo = "The energy type is: Electricity";

			return base.ToString() + EngineInfo;
		}
	}
}

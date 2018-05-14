using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class FuelEngine : Engine
	{
		private eFuelType m_FuelType;
		private float m_MaxEnergyCapacity;
		private float m_CurrentEnergyCapacity;
		private readonly dictEngineMaxCapacity m_dictFuelMaxCapacity;

		public FuelEngine(eFuelType i_FuelType, float i_MaxEnergyCapacity, float i_CurrentEnergyCapacity, string i_VehicleType)
		{
			m_dictFuelMaxCapacity = new dictEngineMaxCapacity();
			m_dictFuelMaxCapacity.dictFuelMaxCapacity.TryGetValue(i_VehicleType, out m_MaxEnergyCapacity);
			m_FuelType = i_FuelType;
			m_MaxEnergyCapacity = i_MaxEnergyCapacity;
			m_CurrentEnergyCapacity = i_CurrentEnergyCapacity;
		}

		public float MaxFuelCapacity
		{
			get { return m_MaxEnergyCapacity; }
			set { m_MaxEnergyCapacity = value; }
		}

		public float CurrentFuelCapacity
		{
			get { return m_CurrentEnergyCapacity; }
			set { m_CurrentEnergyCapacity = value; }
		}

		public eFuelType VehicleFuelType
		{
			get { return m_FuelType; }
			set { m_FuelType = value; }
		}

		public override void AddEnergy(float i_AmountToFill)
		{
			CurrentFuelCapacity += i_AmountToFill;

			if (CurrentFuelCapacity > MaxFuelCapacity)
			{
				CurrentFuelCapacity = MaxFuelCapacity;
            }
        }

		public override string ToString()
		{
			string energyInfo;

			energyInfo = string.Format(
@"Max fuel capacity: {0}
Current fuel amount: {1}",
MaxFuelCapacity,
CurrentFuelCapacity);

			return energyInfo;
		}
	}
}
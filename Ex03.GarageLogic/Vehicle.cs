using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public abstract class Vehicle
	{
		#region Members and Props
		#region Members
		public string m_VehicleBrand;
		public string m_VehicleRegistrationPlate;
		public Wheels m_Wheels;
		public eVehicleStatus m_Status;
		public Engine m_Engine;
		private VehicleOwner m_VehicleOwner;
		#endregion Members

		#region Props
		public Vehicle(string i_VehicleBrand, string i_VehicleRegistrationPlate, Wheels i_Wheels, Engine i_Engine, VehicleOwner i_VehicleOwner)
		{
			m_VehicleBrand = i_VehicleBrand;
			m_VehicleRegistrationPlate = i_VehicleRegistrationPlate;
			m_Wheels = i_Wheels;
			m_Status = eVehicleStatus.InTheAmendment;
			m_Engine = i_Engine;
			m_VehicleOwner = i_VehicleOwner;
        }

		public string VehicleBrand
		{
			get { return m_VehicleBrand; }
			set { m_VehicleBrand = value; }
		}

		public string VehicleRegistrationPlate
		{
			get { return m_VehicleRegistrationPlate; }
			set { m_VehicleRegistrationPlate = value; }
		}

		public eVehicleStatus VehivleStatus
		{
			get { return m_Status; }
			set { m_Status = value; }
		}

		public Wheels VehicleWheel
		{
			get { return m_Wheels; }
			set { m_Wheels = value; }
		}

        public Engine VehicleEngine
        {
            get { return m_Engine; }
            set { m_Engine = value; }
        }

        public VehicleOwner Owner
		{
			get { return m_VehicleOwner; }
			set { m_VehicleOwner = value; }
		}

		#endregion Props
		#endregion Members and Props

		//#region Methods
		public override string ToString()
		{
			string vehicleInfo;

			vehicleInfo = string.Format(
@"
Owner:
{0}

Vehicle:
Brand Name: {1}
Registration plate: {2}
{3}
{4}
",
Owner.ToString(),
VehicleBrand,
VehicleRegistrationPlate,
VehicleWheel.ToString(),
VehicleEngine);

			return vehicleInfo;
		}
	}
}

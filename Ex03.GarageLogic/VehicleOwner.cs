using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public class VehicleOwner
	{
		private readonly string m_OwnerName;
		private readonly string m_OwnerPhoneNumber;

		public VehicleOwner(string i_OwnerName, string i_OwnerPhoneNumber)
		{
			m_OwnerName = i_OwnerName;
			m_OwnerPhoneNumber = i_OwnerPhoneNumber;
		}

		public string OwnerName
		{
			get { return m_OwnerName; }
		//	set { m_OwnerName = value; }
		}

		public string OwnerPhoneNumber
		{
			get { return m_OwnerPhoneNumber; }
		//	set { m_OwnerPhoneNumber = value; }
		}

		public override string ToString()
		{
			string vehicleInGarageOwnerInfo = string.Format(
@"Owner name: {0}
Owner phone number: {1}
",
OwnerName,
OwnerPhoneNumber
);

			return base.ToString() + vehicleInGarageOwnerInfo;
		}
	}
}

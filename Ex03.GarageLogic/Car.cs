using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
	public abstract class Car : Vehicle
	{
		private eCarColor m_Color;
		private eCarDoorsAmount m_DoorsAmount;

		public eCarColor CarColor
		{
			get { return m_Color; }
			set { m_Color = value; }
		}

		public eCarDoorsAmount CarDoorsAmount
		{
			get { return m_DoorsAmount; }
			set { m_DoorsAmount = value; }
		}
	}
}

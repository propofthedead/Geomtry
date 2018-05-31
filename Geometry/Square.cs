using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Square
	{
		public double LengthOfSide { get; set; }

		public double ageArea()
		{
			return LengthOfSide * LengthOfSide;
		}

		public double getPerimeter()
		{
			return LengthOfSide * 4;
		}
	}
}

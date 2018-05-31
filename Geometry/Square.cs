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

		public double areaOfSquare()
		{
			return LengthOfSide * LengthOfSide;
		}

		public double perimeterOfSquare()
		{
			return LengthOfSide * 4;
		}
	}
}

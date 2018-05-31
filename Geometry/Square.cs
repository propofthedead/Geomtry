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

		public double getArea()
		{
			return LengthOfSide * LengthOfSide;
		}

		public double getPerimeter()
		{
			return LengthOfSide * 4;
		}
		public void printSq()
		{
			Console.WriteLine($"A square with the length of {LengthOfSide}, has a area of {getArea()} and a perimeter of {getPerimeter()}");
		}
	}
}

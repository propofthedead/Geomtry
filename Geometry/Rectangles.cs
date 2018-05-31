using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Rectangles
	{
		public double lengthOfRec { get; set; }
		public double widthOfRec { get; set; }

		public double getArea()
		{
			return lengthOfRec * widthOfRec;
		}

		public double getPerimeter()
		{
			return (2 * lengthOfRec) + (2 * widthOfRec);
		}
		public void printRec()
		{
			Console.WriteLine($"The width and length of the rectangle are {widthOfRec}, {lengthOfRec}. So the area is {getArea()} and the perimeter {getPerimeter()}");
		}
	}
}

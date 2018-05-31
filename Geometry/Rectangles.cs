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

		public double getAreaRec()
		{
			return lengthOfRec * widthOfRec;
		}

		public double getPerimRec()
		{
			return (2 * lengthOfRec) + (2 * widthOfRec);
		}
		public void printRec()
		{
			Console.WriteLine($"The width and length of the rectangle are {widthOfRec}, {lengthOfRec}. So the area is {getAreaRec()} and the perimeter {getPerimRec()}");
		}
	}
}

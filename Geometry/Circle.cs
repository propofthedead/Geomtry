using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Circle
	{
		public double raidus { get; set; }
		static double pi = 3.1415;
		public double getArea()
		{
			return ((raidus * raidus) *pi);
		}

		public double getCircumference()
		{
			return (raidus * 2 * pi);
		}

		public void print()
		{
			Console.WriteLine($"The circle has a radius of {raidus}. So the area is {getArea()} and the Circumference is {getCircumference()}");
		}
		public Circle() { }
		public Circle(double r) {
			raidus = r;
		}
	}
}

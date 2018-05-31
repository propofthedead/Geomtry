using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			Square sqr = new Square();
			sqr.LengthOfSide = 2.5;
			double area = sqr.getArea();
			double perimeter = sqr.getPerimeter();
			Console.WriteLine("Area is {0}, perimeter is {1}", area, perimeter);
			Square sqr2 = new Square();
			sqr2.LengthOfSide = 3.3;
			double area2 = sqr2.getArea();
			double perim = sqr2.getPerimeter();
			Console.WriteLine("Second sq are is {0}, the perimeter is {1}", area2, perim);
			sqr.printSq();
		}
	}
}

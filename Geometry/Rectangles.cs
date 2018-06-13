using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	public class Rectangles : Quadrilateral
	{
		public Rectangles(int length, int width) {
			side1 = length;
			side2 = width;
			side3 = length;
			side4 = width;
		}
		public Rectangles() {

		}
		public override int GetArea()
		{
			return this.side1 * this.side2;
		}
		public override int GetPerimeter()
		{
			return (side1 + side2) * 2;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Quadrilateral
	{
		public int side1 { get; set; }
		public int side2 { get; set; }
		public int side3 { get; set; }
		public int side4 { get; set; }

		public int GetPerimeter() {
			return side1 + side2 + side3 + side4 +;
		}
		public virtual int GetArea() {
			return -1;
		}
		public Quadrilateral() {
		}
		public Quadrilateral(int s1, int s2, int s3, int s4) {
			side1 = s1;
			side2 = s2;
			side3 = s3;
			side4 = s4;
		}
	}
}

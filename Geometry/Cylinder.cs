using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Cylinder: Circle
	{
		public double height { get; set; }

		public Cylinder() { }
		public Cylinder(double r, double h) : base(r) {
			height = h;
		}

		public double GetVolume() {
			return base.getArea() * height;
		}
	}
}

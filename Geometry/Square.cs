using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Square : Rectangles
	{

		public Square() { }
		public Square(int sides): base(sides,sides) {
			int side1 = sides;
		}

		public override int GetArea()
		{

			return this.side1 * this.side1;
		}
	}
}

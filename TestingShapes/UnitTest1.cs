using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;

namespace TestingShapes
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		 public void RectangleArea()
		{
			Rectangles rec = new Rectangles(12, 2);
			var value = rec.GetArea();
			Assert.AreEqual(24, value);
		}
		[TestMethod]
		public void InitialRect() {
			Rectangles rec = new Rectangles(1, 2);
			Assert.IsInstanceOfType(rec, typeof(Rectangles));
		}
	}
}

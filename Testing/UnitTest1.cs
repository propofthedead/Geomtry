using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;

namespace Testing
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

		//[TestClass]
		//Rectangles test = new Rectangles(12, 4);
    }
}

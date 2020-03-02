using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lengths;

namespace Lengths.Tests
{
	[TestClass]

	public class TriangleTests
	{
		[TestMethod]
		
		public void IsTriangle_ThreeLengths_True()
		{
			Triangle testTriangle = new Triangle(5, 6, 9);
			Assert.AreEqual(5, testTriangle.Side1);
			Assert.AreEqual(6, testTriangle.Side2);
			Assert.AreEqual(9, testTriangle.Side3);
		}
		
		[TestMethod]

		public void IsTriangle_TrianglePossible_True()
		{
			Triangle testTriangle = new Triangle(5, 6, 20);
			Assert.AreEqual(true, (testTriangle.Side1 + testTriangle.Side2 <= testTriangle.Side3 || testTriangle.Side2 + testTriangle.Side3 <= testTriangle.Side1 || testTriangle.Side3 + testTriangle.Side1 <= testTriangle.Side2));
		}

		[TestMethod]

		public void IsTriangle_Equilateral_True()
		{
			Triangle testTriangle = new Triangle(5, 5, 5);
			Assert.AreEqual(true, (testTriangle.Side1 == testTriangle.Side2 && testTriangle.Side2 == testTriangle.Side3));
		}

		[TestMethod]

		public void IsTriangle_Isosceles_True()
		{
			Triangle testTriangle = new Triangle(5, 5, 6);
			Assert.AreEqual(true, (testTriangle.Side1 == testTriangle.Side2 && testTriangle.Side2 != testTriangle.Side3 || testTriangle.Side1 == testTriangle.Side3 && testTriangle.Side1 != testTriangle.Side2 || testTriangle.Side2 == testTriangle.Side3 && testTriangle.Side2 != testTriangle.Side1));
		}

			[TestMethod]

		public void IsTriangle_Scalene_True()
		{
			Triangle testTriangle = new Triangle(4, 5, 6);
			Assert.AreEqual(true, (testTriangle.Side1 != testTriangle.Side2 && testTriangle.Side2 != testTriangle.Side3 && testTriangle.Side3 != testTriangle.Side1));
		}
		
		
	}
}
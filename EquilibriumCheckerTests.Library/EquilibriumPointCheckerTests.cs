using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumPoint.Library.Tests
{
	[TestFixture]
    public class EquilibriumPointCheckerTests
    {
		[Test]
		public void EquilibriumPointChecker_WhenNoElements_ReturnsMin1() //Sample test
		{
			//Arrange
			int[,] input = new int[0, 0];
			//Act
			int output = EquilibriumPointChecker.GetNumberOfEquilibriumPoints(input);
			//Assert
			Assert.AreEqual(-1, output);
		}
		[Test]
		public void EquilibriumPointChecker_WhenValidInput_ReturnsValidAnswer()
		{
			int[,] input = new int[5, 3] { { 2, 7, 5 }, { 3, 0, 1 }, { 2, 1, -7 }, { 0, 2, 1 }, { 1, 6, 8 } };
			var output = EquilibriumPointChecker.GetNumberOfEquilibriumPoints(input);
			Assert.AreEqual(2, output);
		}
		[Test]
		public void EquilibriumPointChecker_WhenValidInput_ReturnsValidAnswer2()
		{
			int[,] input = new int[5, 3] { { 2, 7, 5 }, { 3, 1, 1 }, { 2, 1, -7 }, { 0, 2, 1 }, { 1, 6, 8 } };
			var output = EquilibriumPointChecker.GetNumberOfEquilibriumPoints(input);
			Assert.AreEqual(2, output);
		}
		[Test]
		public void EquilibriumPointChecker_WhenValidInput_ReturnsValidAnswer3()
		{
			int[,] input = new int[3, 2] { { 1, 3 }, { 2, -6 }, { 1, 3 } };
			var output = EquilibriumPointChecker.GetNumberOfEquilibriumPoints(input);
			Assert.AreEqual(3, output);
		}
	}
}

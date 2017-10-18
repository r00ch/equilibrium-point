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
		public void EquilibriumPointChecker_WhenNoElements_Returns0()
		{
			//Arrange
			int[,] input = new int[0, 0];
			//Act
			int output = EquilibriumPointChecker.GetNumberOfEquilibriumPoints(input);
			//Assert
			Assert.AreEqual(0, output);
		}
    }
}

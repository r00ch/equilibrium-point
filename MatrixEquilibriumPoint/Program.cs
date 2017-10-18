using EquilibriumPoint.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixEquilibriumPoint
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] input = new int[5, 3] { { 2, 7, 5 }, { 3, 1, 1 }, { 2, 1, -7 }, { 0, 2, 1 }, { 1, 6, 8 } };
			Console.WriteLine(EquilibriumPointChecker.GetNumberOfEquilibriumPoints(input));
			Console.ReadLine();
		}
	}
}

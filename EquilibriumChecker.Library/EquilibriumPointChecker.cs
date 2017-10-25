using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumPoint.Library
{
	public class EquilibriumPointChecker
	{
		public static int GetNumberOfEquilibriumPoints(int[,] input)
		{
			if (input.Length == 0) return -1;

			int equilibriumPointsCount = 0;
			int equilibriumForColumnsCount = 0;
			int equilibriumForRowsCount = 0;

			equilibriumForColumnsCount = CountEquilibriumPointsForColumns(input);
			equilibriumForRowsCount = CountEquilibriumPointsForRows(input);

			equilibriumPointsCount = equilibriumForColumnsCount * equilibriumForRowsCount;

			return equilibriumPointsCount;
		}

		public static int CountEquilibriumPointsForRows(int[,] input)
		{
			int equilibriumForRowsCount = 0;

			for (int row = 0; row < input.GetLength(1); row++)
			{
				int sumOfElemInRowsAbove = 0;
				int sumOfElemInRowsBeyond = 0;

				for (int i = 0; i < row; i++) //above
				{
					for (int j = 0; j < input.GetLength(0); j++)
					{
						sumOfElemInRowsAbove += input[j, i];
					}
				}

				for (int i = row + 1; i < input.GetLength(1); i++)
				{
					for (int j = 0; j < input.GetLength(0); j++)
					{
						sumOfElemInRowsBeyond += input[j, i];
					}
				}

				if (sumOfElemInRowsAbove == sumOfElemInRowsBeyond)
				{
					equilibriumForRowsCount++;
				} 
			}
			return equilibriumForRowsCount;
		}

		public static int CountEquilibriumPointsForColumns(int[,] input)
		{
			int equilibriumForColumnsCount = 0;
			for (int column = 0; column < input.GetLength(0); column++)
			{
				int sumOfElemInColumnsOnLeft = 0;
				int sumOfElemInColumnsOnRight = 0;

				for (int i = 0; i < column; i++) //left
				{
					for (int j = 0; j < input.GetLength(1); j++)
					{
						sumOfElemInColumnsOnLeft += input[i, j];
					}
				}

				for (int i = column + 1; i < input.GetLength(0); i++)
				{
					for (int j = 0; j < input.GetLength(1); j++)
					{
						sumOfElemInColumnsOnRight += input[i, j];
					}
				}

				if (sumOfElemInColumnsOnLeft == sumOfElemInColumnsOnRight)
				{
					equilibriumForColumnsCount++;
				}
			}

			return equilibriumForColumnsCount;
		}
	}
}

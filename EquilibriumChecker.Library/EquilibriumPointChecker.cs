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

			for (int columns = 0; columns < input.GetLength(0); columns++)
			{
				for (int rows = 0; rows < input.GetLength(1); rows++)
				{
					int sumOfElemInRowsAbove = 0;
					int sumOfElemInRowsBeyond = 0;
					bool rowSumsMatch = false;

					int sumOfElemInColumnsOnLeft = 0;
					int sumOfElemInColumnsOnRight = 0;
					bool colSumsMatch = false;

					for (int i = 0; i < rows; i++) //above
					{
						for (int j = 0; j < input.GetLength(0); j++)
						{
							sumOfElemInRowsAbove += input[j, i];
						}
					}

					for (int i = rows + 1; i < input.GetLength(1); i++)
					{
						for (int j = 0; j < input.GetLength(0); j++)
						{
							sumOfElemInRowsBeyond += input[j, i];
						}
					}

					if (sumOfElemInRowsAbove == sumOfElemInRowsBeyond)
					{
						rowSumsMatch = true;
					}

					for (int i = 0; i < columns; i++) //left
					{
						for (int j = 0; j < input.GetLength(1); j++)
						{
							sumOfElemInColumnsOnLeft += input[i, j];
						}
					}

					for (int i = columns + 1; i < input.GetLength(0); i++)
					{
						for (int j = 0; j < input.GetLength(1); j++)
						{
							sumOfElemInColumnsOnRight += input[i, j];
						}
					}

					if (sumOfElemInColumnsOnLeft == sumOfElemInColumnsOnRight)
					{
						colSumsMatch = true;
					}

					if (colSumsMatch && rowSumsMatch)
					{
						equilibriumPointsCount++;
						Console.WriteLine("PEP: " + columns + " " + rows);
					}
				}
			}

			return equilibriumPointsCount;
		}
	}
}

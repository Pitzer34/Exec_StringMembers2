using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算兩數之和,並只呈現小數二位數
			Double number1 = 1.23;
			Double number2 = 2.34;

			Double sum =number1 + number2;

			Console.WriteLine(sum.ToString("0.00"));
		}
	}
}

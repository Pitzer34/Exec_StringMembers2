using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//將" abc "左右的空白刪除
			String Value1 = " abc ";
			String Value2 = Value1.Trim();

			Console.WriteLine(Value2);
		}
	}
}

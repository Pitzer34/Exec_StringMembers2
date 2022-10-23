using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"
			string Value1 = "Allen Kuo";
			String Value2 = Value1.ToUpper();

			Console.WriteLine(Value2);

		}
	}
}

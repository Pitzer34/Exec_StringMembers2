using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
			String Value1 = "1100225";
			String TaiwanYear = Value1.Substring(0, 3);
			String month = Value1.Substring(3, 2);
			String day = Value1.Substring(5, 2);

			int Year = Convert.ToInt32(TaiwanYear) + 1911;

			String NewDate = Year.ToString() + "/" + month + "/" + day;
			//DateTime dt = Convert.ToDateTime(NewDate);

			Console.WriteLine(NewDate);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//比對使用者輸入值是否為 "Allen", 區分大小寫
			String ans = "Allen";


			Console.Write("請輸入Allen");
			String input = Console.ReadLine();
			
			if (String.IsNullOrEmpty(input))
			{
				Console.WriteLine("你尚未輸入");
				return;
			}

			if (input == ans)
			{
				Console.WriteLine("輸入正確");
			}
			else
			{
				Console.WriteLine("輸入錯誤");
			}

		}
	}
}

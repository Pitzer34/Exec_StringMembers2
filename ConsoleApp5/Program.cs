using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//比對使用者輸入值是否為 "Allen" 不拘大小寫
			String ans = "Allen";


			Console.Write("請輸入Allen");
			String input = Console.ReadLine();

			if (String.IsNullOrEmpty(input))
			{
				Console.WriteLine("你尚未輸入");
				return;
			}
			
			if (input.ToLower() == ans.ToLower())
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

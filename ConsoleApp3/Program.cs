using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			String name1 = "aLLeN kUO";
			String[] words = name1.ToLower().Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				words[i] = words[i].Substring(0, 1).ToUpper()+words[i].Substring(1);
			}
			
			String result = String.Join(" ", words);
			Console.WriteLine(result);
		}
	}
}

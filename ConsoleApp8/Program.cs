using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//隱藏手機的資訊,呈現 0935****46
			//設原手機號碼為 0935123446

			String PhoneNumber = "0935123446";
			String SecretPhoneNumber = PhoneNumber.Substring(0, 4) + "****" + PhoneNumber.Substring(8, 2);

			Console.WriteLine(SecretPhoneNumber);
		}
	}
}

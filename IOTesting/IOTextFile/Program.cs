using System;

namespace IOTextFile
{
	class MainClass
	{
		public static STable _STable = new STable();
		public static IOSettings _io=new IOSettings(_STable);

		public static void Main (string[] args)
		{
			//			if (_io.save()) {
//				Console.WriteLine ("Записът е успешен");
//			} else {
//				Console.WriteLine ("Записът НЕ е успешен");
//			}
			if (_io.open()) {
				Console.WriteLine ("Четенето е успешно");
			} else {
				Console.WriteLine ("Четенето НЕ е успешно");
			}
			Console.WriteLine (_STable.stable[2]);
		}
	}
}

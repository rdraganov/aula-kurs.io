using System;

namespace IOTextFile
{
	public class IOSettings
	{
		private STable _stable;
		public IOSettings (STable stable)
		{
			_stable = stable;
		}

		public string getPath()
		{
			string _path=System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"test.txt");
			string _user = Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData);
			Console.WriteLine (_user);
			string _desktop = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
			Console.WriteLine (_desktop);
			return _path;
		}


		public bool save()
		{
			try{
				string _temp="";
				_temp=string.Join("\r\n",_stable.stable);
				//запис на текстов файл
				System.IO.File.WriteAllText("d:\\aula\\test.txt",_temp);
				return true;
			}catch{
			}
			return false;
		}

		public bool open()
		{
			try{
				string _temp = "", filePath=getPath();
				if (System.IO.File.Exists(filePath))
					_temp=System.IO.File.ReadAllText(filePath);
				else {
					Console.WriteLine("Пътят не е намерен.");
					return false;}

				string[] _table=_temp.Replace("\r","").Split('\n');
				for (int i=0; i<_table.Length; i++)
				{
					_stable.stable[i]=_table[i];
				}
				return true;
			}catch{
			}
			return false;

		}


	}
}


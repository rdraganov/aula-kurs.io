using System;
using System.Xml;
using System.Xml.Linq;

namespace IOXmlFile
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string value = "", property = "";
			string path = System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test.xml");

			//Четене от Xml файл
			using (XmlReader reader = XmlReader.Create (path)) {
				while (reader.Read ()) {
					switch (reader.Name) {
					case "row":
						property = reader ["property"];
						value = reader.ReadInnerXml ();
						Console.WriteLine ("value = "+ value);
						Console.WriteLine ("property = "+ property);
						break;
					case "simplerow":
						//property = reader ["property"];
						value = reader.ReadInnerXml ();
						Console.WriteLine ("value = "+ value);
						//Console.WriteLine ("property = "+ property);
						break;
					}
				}
			}

		
			Console.ReadKey();

			//Запис в Xml файл
//			using (XmlWriter writer = XmlWriter.Create (path)) {
//				writer.WriteStartDocument ();
//
//				writer.WriteStartElement ("settings");
//
//				writer.WriteStartElement ("row");
//
//				writer.WriteAttributeString ("property", property);
//				writer.WriteString (value);
//
//				writer.WriteEndElement ();
//
//				writer.WriteEndElement();
//
//				writer.WriteEndDocument ();
//			}
//			XDocument document = XDocument.Load (path);
//			document.Save (path);
//
//			System.Diagnostics.Process.Start (path);
				
		}
	}
}

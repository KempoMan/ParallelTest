using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Xml.Serialization;

//added for streamreader

namespace TestOpenXMLSDK
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"C:\Users\Kempo\Downloads\nonStupidName.docx"; //change the path

			string nameSpace = null; //this is where we would put the namespace of the customXMLPart.
									 //For now, just accessing the customXMLPart by looping through
									 //the collection and assuming there's only one.  Only one for
									 //now but will need to change later.
			AccessCustomXMLPart(fileName, nameSpace);
		}


		public static void AccessCustomXMLPart(string fileName, string nameSpace)
		{
			using (var document = WordprocessingDocument.Open(fileName, true))
			{
				var custom = document.MainDocumentPart.CustomXmlParts;  //here is where we should use the namespace
																		//to get the customXMLPart, but since there
																		//is only one for now this works

				// IGNORE name of this shitty class for now, we can change it to proper case later
				// but I didn't want to mess with the xml right now:
				parallelCustomXML customXml = null;
				var serializer = new XmlSerializer(typeof(parallelCustomXML));

				foreach (CustomXmlPart p in custom)
				{
					var streamReader = new StreamReader(p.GetStream()); //Should use DOM but just wanted to read out the stream
					customXml = (parallelCustomXML) serializer.Deserialize(streamReader);
					Console.Write(streamReader.ReadToEnd());
				}

				foreach (parallelCustomXMLVariablesVariable testVar in customXml.variables.Items.Where(t => t.GetType() == typeof(parallelCustomXMLVariablesVariable)))
				{
					Console.WriteLine(testVar.id);
					Console.WriteLine(testVar.name);
					Console.WriteLine(testVar.alias);
					Console.WriteLine(testVar.dataType);
					Console.WriteLine(testVar.address);
					Console.WriteLine(testVar.source);
					Console.WriteLine(testVar.defaultFormatting);
				}

				Console.WriteLine("Hit enter to continue.");
				Console.ReadLine();
			}
		}

	}
}


//note:
//gives you the properties of the part but not the content...
//string x = p.GetIdOfPart(p.CustomXmlPropertiesPart);
//StreamReader sr = new StreamReader(p.CustomXmlPropertiesPart.GetStream());
//string y = sr.ReadToEnd();

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

//added for streamreader

namespace TestOpenXMLSDK
{
	class Program
	{
		const string FileName = @"C:\easyDocs\nonStupidName.docx"; //change the path
		const string DataSourceFileName = @"C:\easyDocs\DataSource6forPOC.xml"; //change the path

		static void Main(string[] args)
		{
			

			string nameSpace = null; //this is where we would put the namespace of the customXMLPart.
									 //For now, just accessing the customXMLPart by looping through
									 //the collection and assuming there's only one.  Only one for
									 //now but will need to change later.

			// TODO: Open document like in other project first.

			AccessCustomXMLPart(FileName, nameSpace);
		}


		public static void AccessCustomXMLPart(string fileName, string nameSpace)
		{
			using (var document = WordprocessingDocument.Open(fileName, true))
			{
				var customXmlParts = document.MainDocumentPart.CustomXmlParts;  //here is where we should use the namespace
																		//to get the customXMLPart, but since there
																		//is only one for now this works

				// IGNORE name of this shitty class for now, we can change it to proper case later
				// but I didn't want to mess with the xml right now:
				parallelCustomXML customXml = null;

				var serializer = new XmlSerializer(typeof(parallelCustomXML));

				foreach (var p in customXmlParts)
				{
					var streamReader = new StreamReader(p.GetStream()); //Should use DOM but just wanted to read out the stream
					customXml = (parallelCustomXML) serializer.Deserialize(streamReader);
					Console.Write(streamReader.ReadToEnd());
				}

				if (customXml == null) throw new NullReferenceException();

				var dataSource = LoadDataSource();
				var customers = dataSource.SelectNodes("/CUSTOMERS/CUSTOMER");
				var wordDoc = LoadWordDoc();

				//var contentControlInstances = customXml.contentControlInstances;  // ignore for now

				foreach (var contentControl in customXml.contentControlInstances)
				{
					foreach (parallelCustomXMLVariablesVariable theVariable
						in customXml.variables.Items.Where(t => t.GetType() == typeof(parallelCustomXMLVariablesVariable)))
					{
						if (theVariable.id == contentControl.variable.id)
						{
							var dataType = theVariable.dataType;
							string value = string.Empty;

							var address = theVariable.address;

							var temp = contentControl.docPart;



							var val = dataSource.SelectNodes(address);

							Console.WriteLine(val);
						}
					}
				}

				//foreach (var customer in dataSource.CUSTOMER)
				//{
				//	Console.WriteLine(customer.CUSTOMER_DEMOGRAPHIC.LAST_NAME);
				//}

				//foreach (parallelCustomXMLVariablesVariable testVar in customXml.variables.Items
				//	.Where(t => t.GetType() == typeof(parallelCustomXMLVariablesVariable)))
				//{
				//	Console.WriteLine(testVar.id);
				//	Console.WriteLine(testVar.name);
				//	Console.WriteLine(testVar.alias);
				//	Console.WriteLine(testVar.dataType);
				//	Console.WriteLine(testVar.address);
				//	Console.WriteLine(testVar.source);
				//	Console.WriteLine(testVar.defaultFormatting);
				//}

				Console.WriteLine("Hit enter to continue.");
				Console.ReadLine();
			}
		}

		private static WordprocessingDocument LoadWordDoc()
		{
			using (var wordDoc =  WordprocessingDocument.Open(@"c:\tmp\test1.docx", true))
			{
				//string docText = null;
				//using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
				//{
				//	docText = sr.ReadToEnd();
				//}

				//ReplaceContent(wordDoc, "4", "Alan");
				//ReplaceContent(wordDoc, "5", "Fitzgerald");

				//using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
				//{
				//	sw.Write(docText);
				//}

				// wordDoc.Save();

				return wordDoc;

			}
		}

		public static void ReplaceContent(WordprocessingDocument wordDoc, string contentControlTag, string text)
		{

			var e2 = wordDoc.Parts;

			var element = wordDoc.MainDocumentPart.Document.Body.Descendants<SdtElement>()
				.FirstOrDefault(sdt => sdt.SdtProperties.GetFirstChild<Tag>()?.Val == contentControlTag);

			if (element == null)
			{
				throw new ArgumentException($"ContentControlTag \"{contentControlTag}\" doesn't exist.");
			}

			element.Descendants<Text>().First().Text = text;
			//element.Descendants<Text>().Skip(1).ToList().ForEach(t => t.Remove());
		}

		private static XmlDocument LoadDataSource()
		{
			var doc = new XmlDocument();
			doc.Load(DataSourceFileName);

			return doc;
		}
	}
}


//note:
//gives you the properties of the part but not the content...
//string x = p.GetIdOfPart(p.CustomXmlPropertiesPart);
//StreamReader sr = new StreamReader(p.CustomXmlPropertiesPart.GetStream());
//string y = sr.ReadToEnd();

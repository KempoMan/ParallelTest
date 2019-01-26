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
		const string TemplateFilename = @"C:\easyDocs\template.docx"; //change the path
		const string DataSourceFileName = @"C:\easyDocs\DataSource6forPOC.xml"; //change the path

		static void Main(string[] args)
		{


			string nameSpace = null; //this is where we would put the namespace of the customXMLPart.
									 //For now, just accessing the customXMLPart by looping through
									 //the collection and assuming there's only one.  Only one for
									 //now but will need to change later.

			// TODO: Open document like in other project first.

			// Open template
			var template = WordprocessingDocument.Open(TemplateFilename, true);

			// Get customxml from template
			var mainDocumentPart = GetMainDocumentPart(template);
			var customXml = GetCustomXmlFromMainBody(mainDocumentPart);
			//var documentXml = GetDocumentXml(TemplateFilename);

			// get customerRecordDelimiter from customXml
			var customerRecordDelimiter = customXml.dataSource.recordDelimiter;

			// load datasource (using customerRecordDelimiter to get customer data)
			var dataSource = LoadDataSourceByDelimiter(customerRecordDelimiter);

			foreach (XmlNode record in dataSource)
			{
				foreach (var contentControl in customXml.contentControlInstances)
				{
					var contentControlVariable = contentControl.variable;
					var docPart = contentControl.docPart;

					// use id from above to parallelCustomXML/variables/variable/id
					// get address from variable (<address>/CUSTOMER/CUSTOMER_DEMOGRAPHIC/FIRST_NAME</address>)
					foreach (parallelCustomXMLVariablesVariable variable in customXml.variables.Items)
					{
						if (variable.id == contentControlVariable.id)
						{
							//var address = variable.address;
							var address = "CUSTOMER_DEMOGRAPHIC/FIRST_NAME";

							// datasource/address will give you value that you need

							//Console.WriteLine(record.SelectSingleNode(address).InnerText);

							var tempDocpart = docPart.Replace(variable.name, record.SelectSingleNode(address).InnerText);

							//foreach (var documentXmlPart in documentXml.Parts)
							//{
							//	Console.WriteLine(documentXml);
							//}
							Console.WriteLine(mainDocumentPart);



						}
					}
				}

				//var node = record.SelectNodes(address);
				//Console.WriteLine(node.Value);
			}



			// go to first content control instance found in customXml (get Id (and other info like address and docpart)
			// of content control (<variable id="4">FIRST_NAME</variable>))
			// get docpart (contains ooxml [contains variable or thing you're going to replace]) from current content control instance 
			foreach (var contentControl in customXml.contentControlInstances)
			{
				var contentControlVariable = contentControl.variable;
				var docPart = contentControl.docPart;

				var ccid = contentControl.id;

				// use id from above to parallelCustomXML/variables/variable/id
				// get address from variable (<address>/CUSTOMER/CUSTOMER_DEMOGRAPHIC/FIRST_NAME</address>)
				foreach (parallelCustomXMLVariablesVariable variable in customXml.variables.Items
					.Where(t => t.GetType() == typeof(parallelCustomXMLVariablesVariable)))
				{
					if (variable.id == contentControlVariable.id)
					{
						//var address = variable.address;
						var address = "CUSTOMER_DEMOGRAPHIC/FIRST_NAME";

						// datasource/address will give you value that you need

						// todo: figure out how to loop through customer records (1 million no key)
						foreach (XmlNode record in dataSource)
						{
							//var node = record.SelectNodes(address);
							Console.WriteLine(record.SelectSingleNode(address).InnerText);
							//Console.WriteLine(node.Value);
						}

					}
				}


			}










			//AccessCustomXmlPart(FileName, nameSpace);
		}

		private static parallelCustomXML GetCustomXmlFromMainBody(MainDocumentPart mainBodyPart)
		{
			var serializer = new XmlSerializer(typeof(parallelCustomXML));
			parallelCustomXML customXml = null;
			var customXmlParts = mainBodyPart.CustomXmlParts;

			foreach (var p in customXmlParts)
			{
				var streamReader = new StreamReader(p.GetStream()); //Should use DOM but just wanted to read out the stream
				customXml = (parallelCustomXML)serializer.Deserialize(streamReader);
				Console.Write(streamReader.ReadToEnd());
			}

			return customXml;
		}

		private static WordprocessingDocument GetDocumentXml(string template)
		{

			var wordDoc = WordprocessingDocument.Open(template, false);

			MainDocumentPart mainPart = wordDoc.MainDocumentPart;
			return wordDoc;

		}

		private static XmlDocument GetCustomXmlDoc(WordprocessingDocument template)
		{
			var doc = new XmlDocument();
			doc.Load(DataSourceFileName);

			return doc;
		}

		// TODO: Refactor because file could contain hundreds of thousands of records
		private static XmlNodeList LoadDataSourceByDelimiter(string delimiter)
		{
			var doc = new XmlDocument();
			doc.Load(DataSourceFileName);

			return doc.SelectNodes(delimiter);
		}

		private static MainDocumentPart GetMainDocumentPart(WordprocessingDocument document)
		{
			var serializer = new XmlSerializer(typeof(parallelCustomXML));
			var customXmlParts = document.MainDocumentPart.CustomXmlParts;

			var body = document.MainDocumentPart.Document.Body;

			//parallelCustomXML customXml = null;

			//foreach (var p in customXmlParts)
			//{
			//	var streamReader = new StreamReader(p.GetStream()); //Should use DOM but just wanted to read out the stream
			//	customXml = (parallelCustomXML)serializer.Deserialize(streamReader);
			//	Console.Write(streamReader.ReadToEnd());
			//}

			//return customXml;

			return document.MainDocumentPart;
			//return body;
		}


		public static void AccessCustomXmlPart(string fileName, string nameSpace)
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
					customXml = (parallelCustomXML)serializer.Deserialize(streamReader);
					Console.Write(streamReader.ReadToEnd());
				}

				if (customXml == null) throw new NullReferenceException();

				//var dataSource = LoadDataSourceByDelimiter();
				//var customers = dataSource.SelectNodes("/CUSTOMERS/CUSTOMER");


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



							//var val = dataSource.SelectNodes(address);

							//Console.WriteLine(val);
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
			using (var wordDoc = WordprocessingDocument.Open(@"c:\tmp\test1.docx", true))
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


	}
}


//note:
//gives you the properties of the part but not the content...
//string x = p.GetIdOfPart(p.CustomXmlPropertiesPart);
//StreamReader sr = new StreamReader(p.CustomXmlPropertiesPart.GetStream());
//string y = sr.ReadToEnd();

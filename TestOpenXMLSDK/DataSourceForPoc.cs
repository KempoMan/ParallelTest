using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpenXMLSDK
{


		// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
		public partial class CUSTOMERS
		{

			private CUSTOMERSCUSTOMER[] cUSTOMERField;

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute("CUSTOMER")]
			public CUSTOMERSCUSTOMER[] CUSTOMER
			{
				get
				{
					return this.cUSTOMERField;
				}
				set
				{
					this.cUSTOMERField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMER
		{

			private CUSTOMERSCUSTOMERCUSTOMER_DEMOGRAPHIC cUSTOMER_DEMOGRAPHICField;

			private CUSTOMERSCUSTOMERORGANIZATION[] oRGANIZATIONSField;

			private CUSTOMERSCUSTOMERBILLING bILLINGField;

			private CUSTOMERSCUSTOMERFINANCIAL fINANCIALField;

			/// <remarks/>
			public CUSTOMERSCUSTOMERCUSTOMER_DEMOGRAPHIC CUSTOMER_DEMOGRAPHIC
			{
				get
				{
					return this.cUSTOMER_DEMOGRAPHICField;
				}
				set
				{
					this.cUSTOMER_DEMOGRAPHICField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlArrayItemAttribute("ORGANIZATION", IsNullable = false)]
			public CUSTOMERSCUSTOMERORGANIZATION[] ORGANIZATIONS
			{
				get
				{
					return this.oRGANIZATIONSField;
				}
				set
				{
					this.oRGANIZATIONSField = value;
				}
			}

			/// <remarks/>
			public CUSTOMERSCUSTOMERBILLING BILLING
			{
				get
				{
					return this.bILLINGField;
				}
				set
				{
					this.bILLINGField = value;
				}
			}

			/// <remarks/>
			public CUSTOMERSCUSTOMERFINANCIAL FINANCIAL
			{
				get
				{
					return this.fINANCIALField;
				}
				set
				{
					this.fINANCIALField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERCUSTOMER_DEMOGRAPHIC
		{

			private byte cUSTOMER_IDField;

			private ulong aCCOUNT_NUMBERField;

			private string tITLEField;

			private string fIRST_NAMEField;

			private string lAST_NAMEField;

			private string aDDR1Field;

			private string aDDR2Field;

			private string cITYField;

			private string sTATEField;

			private uint zIPField;

			private uint pHONEField;

			private string pHONE2Field;

			private string pHONE3Field;

			private System.DateTime dOBField;

			private string gENDERField;

			private bool eXISTING_CUSTOMERField;

			private string lEVELField;

			private System.DateTime bEGIN_DATEField;

			private System.DateTime eND_DATEField;

			private string wSDLField;

			private CUSTOMERSCUSTOMERCUSTOMER_DEMOGRAPHICFreeFields freeFieldsField;

			/// <remarks/>
			public byte CUSTOMER_ID
			{
				get
				{
					return this.cUSTOMER_IDField;
				}
				set
				{
					this.cUSTOMER_IDField = value;
				}
			}

			/// <remarks/>
			public ulong ACCOUNT_NUMBER
			{
				get
				{
					return this.aCCOUNT_NUMBERField;
				}
				set
				{
					this.aCCOUNT_NUMBERField = value;
				}
			}

			/// <remarks/>
			public string TITLE
			{
				get
				{
					return this.tITLEField;
				}
				set
				{
					this.tITLEField = value;
				}
			}

			/// <remarks/>
			public string FIRST_NAME
			{
				get
				{
					return this.fIRST_NAMEField;
				}
				set
				{
					this.fIRST_NAMEField = value;
				}
			}

			/// <remarks/>
			public string LAST_NAME
			{
				get
				{
					return this.lAST_NAMEField;
				}
				set
				{
					this.lAST_NAMEField = value;
				}
			}

			/// <remarks/>
			public string ADDR1
			{
				get
				{
					return this.aDDR1Field;
				}
				set
				{
					this.aDDR1Field = value;
				}
			}

			/// <remarks/>
			public string ADDR2
			{
				get
				{
					return this.aDDR2Field;
				}
				set
				{
					this.aDDR2Field = value;
				}
			}

			/// <remarks/>
			public string CITY
			{
				get
				{
					return this.cITYField;
				}
				set
				{
					this.cITYField = value;
				}
			}

			/// <remarks/>
			public string STATE
			{
				get
				{
					return this.sTATEField;
				}
				set
				{
					this.sTATEField = value;
				}
			}

			/// <remarks/>
			public uint ZIP
			{
				get
				{
					return this.zIPField;
				}
				set
				{
					this.zIPField = value;
				}
			}

			/// <remarks/>
			public uint PHONE
			{
				get
				{
					return this.pHONEField;
				}
				set
				{
					this.pHONEField = value;
				}
			}

			/// <remarks/>
			public string PHONE2
			{
				get
				{
					return this.pHONE2Field;
				}
				set
				{
					this.pHONE2Field = value;
				}
			}

			/// <remarks/>
			public string PHONE3
			{
				get
				{
					return this.pHONE3Field;
				}
				set
				{
					this.pHONE3Field = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
			public System.DateTime DOB
			{
				get
				{
					return this.dOBField;
				}
				set
				{
					this.dOBField = value;
				}
			}

			/// <remarks/>
			public string GENDER
			{
				get
				{
					return this.gENDERField;
				}
				set
				{
					this.gENDERField = value;
				}
			}

			/// <remarks/>
			public bool EXISTING_CUSTOMER
			{
				get
				{
					return this.eXISTING_CUSTOMERField;
				}
				set
				{
					this.eXISTING_CUSTOMERField = value;
				}
			}

			/// <remarks/>
			public string LEVEL
			{
				get
				{
					return this.lEVELField;
				}
				set
				{
					this.lEVELField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
			public System.DateTime BEGIN_DATE
			{
				get
				{
					return this.bEGIN_DATEField;
				}
				set
				{
					this.bEGIN_DATEField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
			public System.DateTime END_DATE
			{
				get
				{
					return this.eND_DATEField;
				}
				set
				{
					this.eND_DATEField = value;
				}
			}

			/// <remarks/>
			public string WSDL
			{
				get
				{
					return this.wSDLField;
				}
				set
				{
					this.wSDLField = value;
				}
			}

			/// <remarks/>
			public CUSTOMERSCUSTOMERCUSTOMER_DEMOGRAPHICFreeFields FreeFields
			{
				get
				{
					return this.freeFieldsField;
				}
				set
				{
					this.freeFieldsField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERCUSTOMER_DEMOGRAPHICFreeFields
		{

			private decimal fREE_FIELD1Field;

			private byte fREE_FIELD2Field;

			private string fREE_FIELD3Field;

			private System.DateTime fREE_FIELD4Field;

			/// <remarks/>
			public decimal FREE_FIELD1
			{
				get
				{
					return this.fREE_FIELD1Field;
				}
				set
				{
					this.fREE_FIELD1Field = value;
				}
			}

			/// <remarks/>
			public byte FREE_FIELD2
			{
				get
				{
					return this.fREE_FIELD2Field;
				}
				set
				{
					this.fREE_FIELD2Field = value;
				}
			}

			/// <remarks/>
			public string FREE_FIELD3
			{
				get
				{
					return this.fREE_FIELD3Field;
				}
				set
				{
					this.fREE_FIELD3Field = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
			public System.DateTime FREE_FIELD4
			{
				get
				{
					return this.fREE_FIELD4Field;
				}
				set
				{
					this.fREE_FIELD4Field = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERORGANIZATION
		{

			private byte idField;

			private string nAMEField;

			private string wEB_ADDRESSField;

			private string eMAILField;

			private string lOGO1Field;

			private string lOGO2Field;

			/// <remarks/>
			public byte ID
			{
				get
				{
					return this.idField;
				}
				set
				{
					this.idField = value;
				}
			}

			/// <remarks/>
			public string NAME
			{
				get
				{
					return this.nAMEField;
				}
				set
				{
					this.nAMEField = value;
				}
			}

			/// <remarks/>
			public string WEB_ADDRESS
			{
				get
				{
					return this.wEB_ADDRESSField;
				}
				set
				{
					this.wEB_ADDRESSField = value;
				}
			}

			/// <remarks/>
			public string EMAIL
			{
				get
				{
					return this.eMAILField;
				}
				set
				{
					this.eMAILField = value;
				}
			}

			/// <remarks/>
			public string LOGO1
			{
				get
				{
					return this.lOGO1Field;
				}
				set
				{
					this.lOGO1Field = value;
				}
			}

			/// <remarks/>
			public string LOGO2
			{
				get
				{
					return this.lOGO2Field;
				}
				set
				{
					this.lOGO2Field = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERBILLING
		{

			private decimal aMOUNT_DUEField;

			private decimal aMOUNT_PAIDField;

			private string sTATUSField;

			private string pAYMENT_TYPEField;

			private string aUTH_TYPEField;

			private string aUTH_PMT_DATEField;

			private ushort pMT_ACCT_NUMField;

			/// <remarks/>
			public decimal AMOUNT_DUE
			{
				get
				{
					return this.aMOUNT_DUEField;
				}
				set
				{
					this.aMOUNT_DUEField = value;
				}
			}

			/// <remarks/>
			public decimal AMOUNT_PAID
			{
				get
				{
					return this.aMOUNT_PAIDField;
				}
				set
				{
					this.aMOUNT_PAIDField = value;
				}
			}

			/// <remarks/>
			public string STATUS
			{
				get
				{
					return this.sTATUSField;
				}
				set
				{
					this.sTATUSField = value;
				}
			}

			/// <remarks/>
			public string PAYMENT_TYPE
			{
				get
				{
					return this.pAYMENT_TYPEField;
				}
				set
				{
					this.pAYMENT_TYPEField = value;
				}
			}

			/// <remarks/>
			public string AUTH_TYPE
			{
				get
				{
					return this.aUTH_TYPEField;
				}
				set
				{
					this.aUTH_TYPEField = value;
				}
			}

			/// <remarks/>
			public string AUTH_PMT_DATE
			{
				get
				{
					return this.aUTH_PMT_DATEField;
				}
				set
				{
					this.aUTH_PMT_DATEField = value;
				}
			}

			/// <remarks/>
			public ushort PMT_ACCT_NUM
			{
				get
				{
					return this.pMT_ACCT_NUMField;
				}
				set
				{
					this.pMT_ACCT_NUMField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERFINANCIAL
		{

			private CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKING rETAIL_BANKINGField;

			/// <remarks/>
			public CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKING RETAIL_BANKING
			{
				get
				{
					return this.rETAIL_BANKINGField;
				}
				set
				{
					this.rETAIL_BANKINGField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKING
		{

			private CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENT sTATEMENTField;

			/// <remarks/>
			public CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENT STATEMENT
			{
				get
				{
					return this.sTATEMENTField;
				}
				set
				{
					this.sTATEMENTField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENT
		{

			private CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTTRANSACTION[] gENERAL_TRANSACTIONSField;

			private CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTACCOUNT[] dETAILED_TRANSACTIONSField;

			/// <remarks/>
			[System.Xml.Serialization.XmlArrayItemAttribute("TRANSACTION", IsNullable = false)]
			public CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTTRANSACTION[] GENERAL_TRANSACTIONS
			{
				get
				{
					return this.gENERAL_TRANSACTIONSField;
				}
				set
				{
					this.gENERAL_TRANSACTIONSField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlArrayItemAttribute("ACCOUNT", IsNullable = false)]
			public CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTACCOUNT[] DETAILED_TRANSACTIONS
			{
				get
				{
					return this.dETAILED_TRANSACTIONSField;
				}
				set
				{
					this.dETAILED_TRANSACTIONSField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTTRANSACTION
		{

			private string tYPEField;

			private System.DateTime dATEField;

			private decimal aMOUNTField;

			/// <remarks/>
			public string TYPE
			{
				get
				{
					return this.tYPEField;
				}
				set
				{
					this.tYPEField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
			public System.DateTime DATE
			{
				get
				{
					return this.dATEField;
				}
				set
				{
					this.dATEField = value;
				}
			}

			/// <remarks/>
			public decimal AMOUNT
			{
				get
				{
					return this.aMOUNTField;
				}
				set
				{
					this.aMOUNTField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTACCOUNT
		{

			private string tYPEField;

			private string nAMEField;

			private decimal bEGINNING_BALANCEField;

			private decimal eNDING_BALANCEField;

			private CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTACCOUNTTRANSACTION[] aCCOUNT_TRANSACTIONSField;

			/// <remarks/>
			public string TYPE
			{
				get
				{
					return this.tYPEField;
				}
				set
				{
					this.tYPEField = value;
				}
			}

			/// <remarks/>
			public string NAME
			{
				get
				{
					return this.nAMEField;
				}
				set
				{
					this.nAMEField = value;
				}
			}

			/// <remarks/>
			public decimal BEGINNING_BALANCE
			{
				get
				{
					return this.bEGINNING_BALANCEField;
				}
				set
				{
					this.bEGINNING_BALANCEField = value;
				}
			}

			/// <remarks/>
			public decimal ENDING_BALANCE
			{
				get
				{
					return this.eNDING_BALANCEField;
				}
				set
				{
					this.eNDING_BALANCEField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlArrayItemAttribute("TRANSACTION", IsNullable = false)]
			public CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTACCOUNTTRANSACTION[] ACCOUNT_TRANSACTIONS
			{
				get
				{
					return this.aCCOUNT_TRANSACTIONSField;
				}
				set
				{
					this.aCCOUNT_TRANSACTIONSField = value;
				}
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class CUSTOMERSCUSTOMERFINANCIALRETAIL_BANKINGSTATEMENTACCOUNTTRANSACTION
		{

			private string tYPEField;

			private System.DateTime dATEField;

			private decimal aMOUNTField;

			/// <remarks/>
			public string TYPE
			{
				get
				{
					return this.tYPEField;
				}
				set
				{
					this.tYPEField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
			public System.DateTime DATE
			{
				get
				{
					return this.dATEField;
				}
				set
				{
					this.dATEField = value;
				}
			}

			/// <remarks/>
			public decimal AMOUNT
			{
				get
				{
					return this.aMOUNTField;
				}
				set
				{
					this.aMOUNTField = value;
				}
			}
		}



}

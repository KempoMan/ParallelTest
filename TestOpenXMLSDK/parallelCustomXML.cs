
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.parallel.software/PowerPitch_1.0", IsNullable = false)]
public partial class parallelCustomXML
{

	private parallelCustomXMLVariables variablesField;

	private parallelCustomXMLContentControl[] contentControlInstancesField;

	private parallelCustomXMLRoutines routinesField;

	private parallelCustomXMLDataSource dataSourceField;

	private object taskPanesField;

	private parallelCustomXMLMeta metaField;

	/// <remarks/>
	public parallelCustomXMLVariables variables
	{
		get
		{
			return this.variablesField;
		}
		set
		{
			this.variablesField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlArrayItemAttribute("contentControl", IsNullable = false)]
	public parallelCustomXMLContentControl[] contentControlInstances
	{
		get
		{
			return this.contentControlInstancesField;
		}
		set
		{
			this.contentControlInstancesField = value;
		}
	}

	/// <remarks/>
	public parallelCustomXMLRoutines routines
	{
		get
		{
			return this.routinesField;
		}
		set
		{
			this.routinesField = value;
		}
	}

	/// <remarks/>
	public parallelCustomXMLDataSource dataSource
	{
		get
		{
			return this.dataSourceField;
		}
		set
		{
			this.dataSourceField = value;
		}
	}

	/// <remarks/>
	public object taskPanes
	{
		get
		{
			return this.taskPanesField;
		}
		set
		{
			this.taskPanesField = value;
		}
	}

	/// <remarks/>
	public parallelCustomXMLMeta meta
	{
		get
		{
			return this.metaField;
		}
		set
		{
			this.metaField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLVariables
{

	private object[] itemsField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("array", typeof(parallelCustomXMLVariablesArray))]
	[System.Xml.Serialization.XmlElementAttribute("variable", typeof(parallelCustomXMLVariablesVariable))]
	public object[] Items
	{
		get
		{
			return this.itemsField;
		}
		set
		{
			this.itemsField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLVariablesArray
{

	private byte idField;

	private string nameField;

	private string addressField;

	private string dataTypeField;

	private string sourceField;

	private parallelCustomXMLVariablesArrayVariable[] variableField;

	/// <remarks/>
	public byte id
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
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	public string address
	{
		get
		{
			return this.addressField;
		}
		set
		{
			this.addressField = value;
		}
	}

	/// <remarks/>
	public string dataType
	{
		get
		{
			return this.dataTypeField;
		}
		set
		{
			this.dataTypeField = value;
		}
	}

	/// <remarks/>
	public string source
	{
		get
		{
			return this.sourceField;
		}
		set
		{
			this.sourceField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("variable")]
	public parallelCustomXMLVariablesArrayVariable[] variable
	{
		get
		{
			return this.variableField;
		}
		set
		{
			this.variableField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLVariablesArrayVariable
{

	private object[] itemsField;

	private ItemsChoiceType[] itemsElementNameField;

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("address", typeof(string))]
	[System.Xml.Serialization.XmlElementAttribute("dataType", typeof(string))]
	[System.Xml.Serialization.XmlElementAttribute("defaultFormatting", typeof(string))]
	[System.Xml.Serialization.XmlElementAttribute("id", typeof(byte))]
	[System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
	[System.Xml.Serialization.XmlElementAttribute("source", typeof(string))]
	[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
	public object[] Items
	{
		get
		{
			return this.itemsField;
		}
		set
		{
			this.itemsField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public ItemsChoiceType[] ItemsElementName
	{
		get
		{
			return this.itemsElementNameField;
		}
		set
		{
			this.itemsElementNameField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.parallel.software/PowerPitch_1.0", IncludeInSchema = false)]
public enum ItemsChoiceType
{

	/// <remarks/>
	address,

	/// <remarks/>
	dataType,

	/// <remarks/>
	defaultFormatting,

	/// <remarks/>
	id,

	/// <remarks/>
	name,

	/// <remarks/>
	source,
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLVariablesVariable
{

	private byte idField;

	private string nameField;

	private string aliasField;

	private string defaultFormattingField;

	private string addressField;

	private string dataTypeField;

	private string sourceField;

	/// <remarks/>
	public byte id
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
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	public string alias
	{
		get
		{
			return this.aliasField;
		}
		set
		{
			this.aliasField = value;
		}
	}

	/// <remarks/>
	public string defaultFormatting
	{
		get
		{
			return this.defaultFormattingField;
		}
		set
		{
			this.defaultFormattingField = value;
		}
	}

	/// <remarks/>
	public string address
	{
		get
		{
			return this.addressField;
		}
		set
		{
			this.addressField = value;
		}
	}

	/// <remarks/>
	public string dataType
	{
		get
		{
			return this.dataTypeField;
		}
		set
		{
			this.dataTypeField = value;
		}
	}

	/// <remarks/>
	public string source
	{
		get
		{
			return this.sourceField;
		}
		set
		{
			this.sourceField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLContentControl
{

	private parallelCustomXMLContentControlVariable variableField;

	private string docPartField;

	private string typeField;

	private bool boundField;

	private bool boundFieldSpecified;

	private byte idField;

	/// <remarks/>
	public parallelCustomXMLContentControlVariable variable
	{
		get
		{
			return this.variableField;
		}
		set
		{
			this.variableField = value;
		}
	}

	/// <remarks/>
	public string docPart
	{
		get
		{
			return this.docPartField;
		}
		set
		{
			this.docPartField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string type
	{
		get
		{
			return this.typeField;
		}
		set
		{
			this.typeField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool bound
	{
		get
		{
			return this.boundField;
		}
		set
		{
			this.boundField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool boundSpecified
	{
		get
		{
			return this.boundFieldSpecified;
		}
		set
		{
			this.boundFieldSpecified = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLContentControlVariable
{

	private byte idField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutines
{

	private parallelCustomXMLRoutinesRoutine routineField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutine routine
	{
		get
		{
			return this.routineField;
		}
		set
		{
			this.routineField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutine
{

	private parallelCustomXMLRoutinesRoutineExpression expressionField;

	private parallelCustomXMLRoutinesRoutineSubroutine[] subroutineField;

	private string typeField;

	private byte idField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineExpression expression
	{
		get
		{
			return this.expressionField;
		}
		set
		{
			this.expressionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("subroutine")]
	public parallelCustomXMLRoutinesRoutineSubroutine[] subroutine
	{
		get
		{
			return this.subroutineField;
		}
		set
		{
			this.subroutineField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string type
	{
		get
		{
			return this.typeField;
		}
		set
		{
			this.typeField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineExpression
{

	private parallelCustomXMLRoutinesRoutineExpressionVariable variableField;

	private ushort idField;

	private byte levelField;

	private bool precedenceGroupField;

	private string conditionalField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineExpressionVariable variable
	{
		get
		{
			return this.variableField;
		}
		set
		{
			this.variableField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ushort id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte level
	{
		get
		{
			return this.levelField;
		}
		set
		{
			this.levelField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool precedenceGroup
	{
		get
		{
			return this.precedenceGroupField;
		}
		set
		{
			this.precedenceGroupField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string conditional
	{
		get
		{
			return this.conditionalField;
		}
		set
		{
			this.conditionalField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineExpressionVariable
{

	private byte idField;

	private string nameField;

	private string operatorField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string @operator
	{
		get
		{
			return this.operatorField;
		}
		set
		{
			this.operatorField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutine
{

	private parallelCustomXMLRoutinesRoutineSubroutineExpression expressionField;

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollecton contentCollectonField;

	private byte idField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineExpression expression
	{
		get
		{
			return this.expressionField;
		}
		set
		{
			this.expressionField = value;
		}
	}

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollecton contentCollecton
	{
		get
		{
			return this.contentCollectonField;
		}
		set
		{
			this.contentCollectonField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineExpression
{

	private parallelCustomXMLRoutinesRoutineSubroutineExpressionVariable variableField;

	private ushort idField;

	private byte levelField;

	private bool precedenceGroupField;

	private string conditionalField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineExpressionVariable variable
	{
		get
		{
			return this.variableField;
		}
		set
		{
			this.variableField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ushort id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte level
	{
		get
		{
			return this.levelField;
		}
		set
		{
			this.levelField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool precedenceGroup
	{
		get
		{
			return this.precedenceGroupField;
		}
		set
		{
			this.precedenceGroupField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string conditional
	{
		get
		{
			return this.conditionalField;
		}
		set
		{
			this.conditionalField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineExpressionVariable
{

	private byte idField;

	private string nameField;

	private string operatorField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string @operator
	{
		get
		{
			return this.operatorField;
		}
		set
		{
			this.operatorField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollecton
{

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollectonExpression expressionField;

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControl[] contentControlField;

	private byte idField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollectonExpression expression
	{
		get
		{
			return this.expressionField;
		}
		set
		{
			this.expressionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("contentControl")]
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControl[] contentControl
	{
		get
		{
			return this.contentControlField;
		}
		set
		{
			this.contentControlField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollectonExpression
{

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollectonExpressionVariable variableField;

	private ushort idField;

	private byte levelField;

	private bool precedenceGroupField;

	private string conditionalField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollectonExpressionVariable variable
	{
		get
		{
			return this.variableField;
		}
		set
		{
			this.variableField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ushort id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte level
	{
		get
		{
			return this.levelField;
		}
		set
		{
			this.levelField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool precedenceGroup
	{
		get
		{
			return this.precedenceGroupField;
		}
		set
		{
			this.precedenceGroupField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string conditional
	{
		get
		{
			return this.conditionalField;
		}
		set
		{
			this.conditionalField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollectonExpressionVariable
{

	private byte idField;

	private string nameField;

	private string operatorField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string @operator
	{
		get
		{
			return this.operatorField;
		}
		set
		{
			this.operatorField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControl
{

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlBookmark bookmarkField;

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlExpression expressionField;

	private byte idField;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlBookmark bookmark
	{
		get
		{
			return this.bookmarkField;
		}
		set
		{
			this.bookmarkField = value;
		}
	}

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlExpression expression
	{
		get
		{
			return this.expressionField;
		}
		set
		{
			this.expressionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlBookmark
{

	private byte contentCollectionIdField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte ContentCollectionId
	{
		get
		{
			return this.contentCollectionIdField;
		}
		set
		{
			this.contentCollectionIdField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlExpression
{

	private parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlExpressionVariable variableField;

	private byte levelField;

	private bool precedenceGroupField;

	private string conditionalField;

	private ushort idField;

	private bool idFieldSpecified;

	/// <remarks/>
	public parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlExpressionVariable variable
	{
		get
		{
			return this.variableField;
		}
		set
		{
			this.variableField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte level
	{
		get
		{
			return this.levelField;
		}
		set
		{
			this.levelField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool precedenceGroup
	{
		get
		{
			return this.precedenceGroupField;
		}
		set
		{
			this.precedenceGroupField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string conditional
	{
		get
		{
			return this.conditionalField;
		}
		set
		{
			this.conditionalField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public ushort id
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
	[System.Xml.Serialization.XmlIgnoreAttribute()]
	public bool idSpecified
	{
		get
		{
			return this.idFieldSpecified;
		}
		set
		{
			this.idFieldSpecified = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLRoutinesRoutineSubroutineContentCollectonContentControlExpressionVariable
{

	private byte idField;

	private string nameField;

	private string operatorField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public byte id
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
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string @operator
	{
		get
		{
			return this.operatorField;
		}
		set
		{
			this.operatorField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value
	{
		get
		{
			return this.valueField;
		}
		set
		{
			this.valueField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLDataSource
{

	private string addressField;

	private string recordDelimiterField;

	private string schemaField;

	private string typeField;

	/// <remarks/>
	public string address
	{
		get
		{
			return this.addressField;
		}
		set
		{
			this.addressField = value;
		}
	}

	/// <remarks/>
	public string recordDelimiter
	{
		get
		{
			return this.recordDelimiterField;
		}
		set
		{
			this.recordDelimiterField = value;
		}
	}

	/// <remarks/>
	public string schema
	{
		get
		{
			return this.schemaField;
		}
		set
		{
			this.schemaField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string type
	{
		get
		{
			return this.typeField;
		}
		set
		{
			this.typeField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.parallel.software/PowerPitch_1.0")]
public partial class parallelCustomXMLMeta
{

	private object documentPropertiesField;

	private object markersField;

	/// <remarks/>
	public object documentProperties
	{
		get
		{
			return this.documentPropertiesField;
		}
		set
		{
			this.documentPropertiesField = value;
		}
	}

	/// <remarks/>
	public object markers
	{
		get
		{
			return this.markersField;
		}
		set
		{
			this.markersField = value;
		}
	}
}


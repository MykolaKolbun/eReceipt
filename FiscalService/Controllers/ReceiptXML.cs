namespace FiscalService.Controllers
{
    //------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("CHECK", Namespace="", IsNullable=false)]
public partial class CheckContent {
    
    private CHead cHECKHEADField;
    
    private CTotal cHECKTOTALField;
    
    private TROWSPAY[] cHECKPAYField;
    
    private TROWSTAX[] cHECKTAXField;
    
    private TROWSEXCISE[] cHECKEXCISEField;
    
    private TROWS[] cHECKBODYField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CHead CHECKHEAD {
        get {
            return this.cHECKHEADField;
        }
        set {
            this.cHECKHEADField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CTotal CHECKTOTAL {
        get {
            return this.cHECKTOTALField;
        }
        set {
            this.cHECKTOTALField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ROW", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TROWSPAY[] CHECKPAY {
        get {
            return this.cHECKPAYField;
        }
        set {
            this.cHECKPAYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ROW", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TROWSTAX[] CHECKTAX {
        get {
            return this.cHECKTAXField;
        }
        set {
            this.cHECKTAXField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ROW", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TROWSEXCISE[] CHECKEXCISE {
        get {
            return this.cHECKEXCISEField;
        }
        set {
            this.cHECKEXCISEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ROW", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TROWS[] CHECKBODY {
        get {
            return this.cHECKBODYField;
        }
        set {
            this.cHECKBODYField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CHead {
    
    private string dOCTYPEField;
    
    private string dOCSUBTYPEField;
    
    private string vERField;
    
    private string uIDField;
    
    private string tINField;
    
    private string iNNField;
    
    private string oRGNAMEField;
    
    private string pOINTNAMEField;
    
    private string pOINTADDRField;
    
    private string oRDERDATEField;
    
    private string oRDERTIMEField;
    
    private long oRDERNUMField;
    
    private System.Nullable<long> oRDERTAXNUMField;
    
    private bool oRDERTAXNUMFieldSpecified;
    
    private long cASHDESKNUMField;
    
    private System.Nullable<long> cASHREGISTERNUMField;
    
    private bool cASHREGISTERNUMFieldSpecified;
    
    private string cASHIERField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="nonNegativeInteger")]
    public string DOCTYPE {
        get {
            return this.dOCTYPEField;
        }
        set {
            this.dOCTYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="nonNegativeInteger")]
    public string DOCSUBTYPE {
        get {
            return this.dOCSUBTYPEField;
        }
        set {
            this.dOCSUBTYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string VER {
        get {
            return this.vERField;
        }
        set {
            this.vERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string UID {
        get {
            return this.uIDField;
        }
        set {
            this.uIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TIN {
        get {
            return this.tINField;
        }
        set {
            this.tINField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public string INN {
        get {
            return this.iNNField;
        }
        set {
            this.iNNField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ORGNAME {
        get {
            return this.oRGNAMEField;
        }
        set {
            this.oRGNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string POINTNAME {
        get {
            return this.pOINTNAMEField;
        }
        set {
            this.pOINTNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string POINTADDR {
        get {
            return this.pOINTADDRField;
        }
        set {
            this.pOINTADDRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string ORDERDATE {
        get {
            return this.oRDERDATEField;
        }
        set {
            this.oRDERDATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string ORDERTIME {
        get {
            return this.oRDERTIMEField;
        }
        set {
            this.oRDERTIMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long ORDERNUM {
        get {
            return this.oRDERNUMField;
        }
        set {
            this.oRDERNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> ORDERTAXNUM {
        get {
            return this.oRDERTAXNUMField;
        }
        set {
            this.oRDERTAXNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ORDERTAXNUMSpecified {
        get {
            return this.oRDERTAXNUMFieldSpecified;
        }
        set {
            this.oRDERTAXNUMFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long CASHDESKNUM {
        get {
            return this.cASHDESKNUMField;
        }
        set {
            this.cASHDESKNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<long> CASHREGISTERNUM {
        get {
            return this.cASHREGISTERNUMField;
        }
        set {
            this.cASHREGISTERNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CASHREGISTERNUMSpecified {
        get {
            return this.cASHREGISTERNUMFieldSpecified;
        }
        set {
            this.cASHREGISTERNUMFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CASHIER {
        get {
            return this.cASHIERField;
        }
        set {
            this.cASHIERField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Decimal3Column_R {
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Long5Column {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Str128Column {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Str15Column {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TROWS {
    
    private Str64Column cODEField;
    
    private Str15Column uKTZEDField;
    
    private Str128Column nAMEField;
    
    private Long5Column uNITCODEField;
    
    private Str64Column uNITNAMEField;
    
    private Decimal3Column_R aMOUNTField;
    
    private Decimal2Column pRICEField;
    
    private TaxColumn lETTERField;
    
    private TaxColumn lETTEREXCISEField;
    
    private Decimal2Column cOSTField;
    
    private int rOWNUMField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Str64Column CODE {
        get {
            return this.cODEField;
        }
        set {
            this.cODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Str15Column UKTZED {
        get {
            return this.uKTZEDField;
        }
        set {
            this.uKTZEDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Str128Column NAME {
        get {
            return this.nAMEField;
        }
        set {
            this.nAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Long5Column UNITCODE {
        get {
            return this.uNITCODEField;
        }
        set {
            this.uNITCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Str64Column UNITNAME {
        get {
            return this.uNITNAMEField;
        }
        set {
            this.uNITNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal3Column_R AMOUNT {
        get {
            return this.aMOUNTField;
        }
        set {
            this.aMOUNTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column PRICE {
        get {
            return this.pRICEField;
        }
        set {
            this.pRICEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public TaxColumn LETTER {
        get {
            return this.lETTERField;
        }
        set {
            this.lETTERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public TaxColumn LETTEREXCISE {
        get {
            return this.lETTEREXCISEField;
        }
        set {
            this.lETTEREXCISEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column COST {
        get {
            return this.cOSTField;
        }
        set {
            this.cOSTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int ROWNUM {
        get {
            return this.rOWNUMField;
        }
        set {
            this.rOWNUMField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Str64Column {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Decimal2Column {
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TaxColumn {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TROWSEXCISE {
    
    private TaxColumn eXCISECODEField;
    
    private Decimal2Column eXCISEPRCField;
    
    private Decimal2Column eXCISESUMField;
    
    private int rOWNUMField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public TaxColumn EXCISECODE {
        get {
            return this.eXCISECODEField;
        }
        set {
            this.eXCISECODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column EXCISEPRC {
        get {
            return this.eXCISEPRCField;
        }
        set {
            this.eXCISEPRCField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column EXCISESUM {
        get {
            return this.eXCISESUMField;
        }
        set {
            this.eXCISESUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int ROWNUM {
        get {
            return this.rOWNUMField;
        }
        set {
            this.rOWNUMField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TROWSTAX {
    
    private TaxColumn tAXCODEField;
    
    private Decimal2Column tAXPRCField;
    
    private Decimal2Column tAXSUMField;
    
    private int rOWNUMField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public TaxColumn TAXCODE {
        get {
            return this.tAXCODEField;
        }
        set {
            this.tAXCODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column TAXPRC {
        get {
            return this.tAXPRCField;
        }
        set {
            this.tAXPRCField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column TAXSUM {
        get {
            return this.tAXSUMField;
        }
        set {
            this.tAXSUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int ROWNUM {
        get {
            return this.rOWNUMField;
        }
        set {
            this.rOWNUMField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TROWSPAY {
    
    private Str64Column pAYMENTFORMField;
    
    private Decimal2Column sUMField;
    
    private int rOWNUMField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Str64Column PAYMENTFORM {
        get {
            return this.pAYMENTFORMField;
        }
        set {
            this.pAYMENTFORMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Decimal2Column SUM {
        get {
            return this.sUMField;
        }
        set {
            this.sUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int ROWNUM {
        get {
            return this.rOWNUMField;
        }
        set {
            this.rOWNUMField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CTotal {
    
    private System.Nullable<decimal> tOTALSUMField;
    
    private bool tOTALSUMFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public System.Nullable<decimal> TOTALSUM {
        get {
            return this.tOTALSUMField;
        }
        set {
            this.tOTALSUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TOTALSUMSpecified {
        get {
            return this.tOTALSUMFieldSpecified;
        }
        set {
            this.tOTALSUMFieldSpecified = value;
        }
    }
}

}
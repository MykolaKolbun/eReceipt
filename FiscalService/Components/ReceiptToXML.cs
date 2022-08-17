using System.Text;
using System.Xml;
using System.Xml.Serialization;
namespace FiscalService.Components
{
    public class ReceiptToXML
    {

        #region CheckHead properties
        public string DocType { get; set; }
        public string DocSubType { get; set; }
        public string Uid { get; set; }
        public string Tin { get; set; }
        public string Ipn { get; set; }
        public string OrgNm { get; set; }
        public string PointNm { get; set; }
        public string PointAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderTime { get; set; }
        public int OrderNum { get; set; }
        public int CashDeskNum { get; set; }
        public string CashRegisterNum { get; set; }
        public string Cashier { get; set; }
        public int Ver { get; set; }
        #endregion

        #region CheckTotal properties
        public double TotalSum { get; set; }

        #endregion

        #region CheckPay properties
        public List<CheckPay.Payment> PaymentList { get; set; } = new List<CheckPay.Payment>();
        #endregion

        #region CheckTax properties
        public List<CheckTax.Tax> TaxList { get; set; } = new List<CheckTax.Tax>();
        #endregion

        #region CheckBody propperties
        public List<CheckBody.Body> BodyList { get; set; } = new List<CheckBody.Body>();

        #endregion


        [Serializable]
        [XmlRoot("CHECK")]
        public class CheckBuilder
        {
            [XmlElement("CHECKHEAD")]
            public CheckHead checkHead { get; set; }

            [XmlElement("CHECKTOTAL")]
            public CheckTotal checkTotal { get; set; }

            [XmlElement("CHECKPAY")]
            public CheckPay checkPay { get; set; }

            [XmlElement("CHECKTAX")]
            public CheckTax checkTax { get; set; }

            // [XmlElement("CHECKEXCISE")]
            // public CheckExcise checkExcise { get; set; }

            [XmlElement("CHECKBODY")]
            public CheckBody checkBody { get; set; }
        }

        [Serializable]
        public class CheckHead
        {
            [XmlElement("DOCTYPE")]
            public int DocType { get; set; }

            [XmlElement("DOCSUBTYPE")]
            public int DocSubType { get; set; }

            [XmlElement("UID")]
            public string UID { get; set; }

            [XmlElement("TIN")]
            public string TIN { get; set; }

            [XmlElement("IPN")]
            public string IPN { get; set; }

            [XmlElement("ORGNM")]
            public string OrgName { get; set; }

            [XmlElement("POINTNM")]
            public string PointName { get; set; }

            [XmlElement("POINTADDR")]
            public string PointAddr { get; set; }

            [XmlElement("ORDERDATE")]
            public string OrderDate { get; set; } // TODO add setter to convert DateTime to string in format ddmmyyyy

            [XmlElement("ORDERTIME")]
            public string OrderTime { get; set; } // TODO add setter to convert DateTime to string in format hhmmss

            [XmlElement("ORDERNUM")]
            public int OrderNum { get; set; }

            [XmlElement("CASHDESKNUM")]
            public int CashDeskNum { get; set; }

            [XmlElement("CASHREGISTERNUM")]
            public string CashRegisterNum { get; set; }

            [XmlElement("CASHIER")]
            public string Cashier { get; set; }

            [XmlElement("VER")]
            public int Ver { get; set; }
        }

        [Serializable]
        public class CheckTotal
        {
            [XmlElement("SUM")]
            public double TotalSum { get; set; }
        }

        [Serializable]
        public class CheckPay
        {
            [XmlElement("ROW")]
            public List<Payment> payments { get; set; }
            public CheckPay() { }

            [Serializable]
            public class Payment
            {
                [XmlAttribute("ROWNUM")]
                public int Id { get; set; }

                [XmlElement("PAYFORMCD")]
                public int PaymentFormNum { get; set; }

                [XmlElement("PAYFORMNM")]
                public string PaymentFormName { get; set; }

                [XmlElement("SUM")]
                public double Sum { get; set; }

                [XmlElement("PROVIDED")]
                public double Provided { get; set; }
            }
        }

        [Serializable]
        public class CheckTax
        {
            [XmlElement("ROW")]
            public List<Tax> TaxList { get; set; }
            public CheckTax()
            { }

            [Serializable]
            public class Tax
            {
                [XmlAttribute("ROWNUM")]
                public int Id { get; set; }

                [XmlElement("TYPE")]
                public int TaxType { get; set; }

                [XmlElement("NAME")]
                public string TaxName { get; set; }

                [XmlElement("LETTER")]
                public string TaxLetter { get; set; }

                [XmlElement("PRC")]
                public double TaxPrice { get; set; }

                [XmlElement("TURNOVER")]
                public double TaxTurnover { get; set; }

                [XmlElement("SUM")]
                public double TaxSum { get; set; }
            }
        }

        [Serializable]
        public class CheckBody
        {
            [XmlElement("ROW")]
            public List<Body> BodyRow { get; set; }
            public CheckBody()
            { }

            public class Body
            {
                [XmlAttribute("ROWNUM")]
                public int Id { get; set; }

                [XmlElement("CODE")]
                public string Code { get; set; }

                [XmlElement("UKTZED")]
                public string Uktzed { get; set; }

                [XmlElement("NAME")]
                public string Name { get; set; }

                [XmlElement("UNITNM")]
                public string UnitName { get; set; }

                [XmlElement("AMOUNT")]
                public float Amount { get; set; }

                [XmlElement("PRICE")]
                public double Price { get; set; }

                [XmlElement("LETTER")]
                public string Letter { get; set; }

                [XmlElement("COST")]
                public double Cost { get; set; }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        public static string SerializeToXMLString(CheckBuilder checkBuilder)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (MemoryStream ms = new MemoryStream())
            {
                XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings()
                {
                    CloseOutput = false,
                    Encoding = Encoding.GetEncoding(1251),
                    OmitXmlDeclaration = false,
                    Indent = true
                };
                using (System.Xml.XmlWriter xw = System.Xml.XmlWriter.Create(ms, xmlWriterSettings))
                {
                    XmlSerializer s = new XmlSerializer(typeof(ReceiptToXML.CheckBuilder));
                    s.Serialize(xw, checkBuilder);
                }
                return Encoding.Default.GetString(ms.ToArray());
            }
        }

        public static void SerializeToXMLFile(CheckBuilder checkBuilder)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings()
            {
                CloseOutput = false,
                Encoding = Encoding.GetEncoding(1251),
                OmitXmlDeclaration = false,
                Indent = true
            };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CheckBuilder));
            using (FileStream fs = new FileStream("receipt.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, checkBuilder);
                Console.WriteLine("Object has been serialized");
            }
        }
    }
}
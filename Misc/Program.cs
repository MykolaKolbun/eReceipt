using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.Security.Cryptography;

namespace Misc
{
    public static class Program
    {
        static void Main(string[] args)
        {
            #region Old
            // var child = new Child("Timon", 6);
            // var children = new List<Child>();
            // children.Add(child);
            // var person = new Person("Tom", 42, children);
            // XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            // using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            // {
            //     xmlSerializer.Serialize(fs, person);
            //     Console.WriteLine("Object has been serialized");
            // }

            // var payment = new Payment();
            // payment.PaymentForm = "Cash";
            // payment.Sum = 14;
            // payment.Id=1;

            // var checkPay = new CheckPay();
            // checkPay.payments = new List<Payment>();
            // checkPay.payments.Add(payment);

            // var checkTotal = new CheckTotal();
            // checkTotal.TotalSum = payment.Sum;

            // var checkHead = new CheckHead();
            // checkHead.DocType = 0;
            // checkHead.DocSubType = 0;
            // checkHead.Ver = 1;
            // checkHead.UID = "1234-qwer-5678-asdf-9101-zxcv";
            // checkHead.TIN = "12345678";
            // checkHead.OrgName = "alternatiview.com";
            // checkHead.PointName = "Periproptect";
            // checkHead.PointAddr = "Baker Str. 21";
            // checkHead.OrderDate = "08082022";
            // checkHead.OrderTime = "222210";
            // checkHead.OrderNum = 1234;
            // checkHead.OrderTaxNum = "789456102";
            // checkHead.CashDeskNum = 1;
            // checkHead.CashRegisterNum = "134501";
            // checkHead.Cashier = "Kolbun M";


            // var tax = new CheckTax.Tax();
            // tax.Id=1;
            // tax.TaxCode = "A";
            // tax.TaxPrc = 20.00;
            // tax.TaxSum = (payment.Sum*tax.TaxPrc)/100;

            // var checkTax = new CheckTax();
            // checkTax.TaxRow = new List<CheckTax.Tax>();
            // checkTax.TaxRow.Add(tax);

            // var excise = new CheckExcise.Excise();
            // excise.Id = 1;
            // excise.ExciseCode = "D";
            // excise.ExcisePrc = 5.00;
            // excise.ExciseSum = (payment.Sum*excise.ExcisePrc)/100;

            // var checkExcise = new CheckExcise();
            // checkExcise.ExciseRow = new List<CheckExcise.Excise>();
            // checkExcise.ExciseRow.Add(excise);

            // var body = new CheckBody.Body();
            // body.Id=1;
            // body.Code = "98765";
            // body.UktZed = "987456";
            // body.Name = "Parking";
            // body.UnitCode = "21";
            // body.UnitName = "Hours";
            // body.Amount = 2;
            // body.Price = 12.5;
            // body.Letter = "A";
            // body.Cost = body.Price*body.Amount;

            // var checkBody = new CheckBody();
            // checkBody.BodyRow = new List<CheckBody.Body>();
            // checkBody.BodyRow.Add(body);

            // //----Create XML elements------------------------------    
            // var checkBuilder = new CheckBuilder();
            // checkBuilder.checkHead = checkHead;
            // checkBuilder.checkTotal = checkTotal;
            // checkBuilder.checkPay = checkPay;
            // checkBuilder.checkTax = checkTax;
            // checkBuilder.checkExcise = checkExcise;
            // checkBuilder.checkBody = checkBody;

            // //----Serialize Check to XML
            // XmlSerializer xmlSerializer = new XmlSerializer(typeof(CheckBuilder));
            // using (FileStream fs = new FileStream("receipt.xml", FileMode.OpenOrCreate))
            // {
            //     xmlSerializer.Serialize(fs, checkBuilder);
            //     Console.WriteLine("Object has been serialized");
            // }




            // DateTime timeStamp = DateTime.Now;
            // ReceiptXML.CheckBuilder checkbuilder = new ReceiptXML.CheckBuilder();
            // //-------------------------------------------------------------------

            // ReceiptXML.CheckHead checkHead = new();
            // checkHead.DocType = 0;
            // checkHead.DocSubType = 0;
            // checkHead.UID = "1322-asdd-456a-5466";
            // checkHead.TIN = "10899999";
            // checkHead.IPN = "108999999999";
            // checkHead.OrgName = "Periproptect Ltd.";
            // checkHead.PointName = " ДПМА Бориспіль";
            // checkHead.PointAddr = "Гора 7";
            // checkHead.OrderDate = timeStamp.Date.ToString("ddMMyyyy");
            // checkHead.OrderTime = timeStamp.TimeOfDay.ToString("hhmmss");
            // checkHead.OrderNum = 123;
            // checkHead.CashDeskNum = 1;
            // checkHead.CashRegisterNum = "4000000000001";
            // checkHead.Cashier = "Skidata";
            // checkHead.Ver = 1;

            // checkbuilder.checkHead = checkHead;
            // //-------------------------------------------------------- 

            // ReceiptXML.CheckTotal checkTotal = new();
            // checkTotal.TotalSum = 25.00;

            // checkbuilder.checkTotal = checkTotal;
            // //--------------------------------------------------------
            // ReceiptXML.CheckPay checkPay = new();
            // List<ReceiptXML.CheckPay.Payment> payments = new();
            // ReceiptXML.CheckPay.Payment payment1 = new();
            // payment1.Id = 1;
            // payment1.PaymentFormNum = 0;
            // payment1.PaymentFormName = "Готівка";
            // payment1.Sum = 25.00;
            // payment1.Provided = 25.00;

            // payments.Add(payment1);
            // checkPay.payments = payments;
            // checkbuilder.checkPay = checkPay;
            // //------------------------------------------------------
            // ReceiptXML.CheckTax checkTax = new();
            // List<ReceiptXML.CheckTax.Tax> checkTaxes = new();

            // ReceiptXML.CheckTax.Tax tax = new();
            // tax.Id = 1;
            // tax.TaxType = 0;
            // tax.TaxName = "ПДВ";
            // tax.TaxLetter = "А";
            // tax.TaxPrice = 20.00;
            // tax.TaxTurnover = payment1.Sum;
            // tax.TaxSum = payment1.Sum*tax.TaxPrice/100;

            // checkTaxes.Add(tax);
            // checkTax.TaxList = checkTaxes;
            // checkbuilder.checkTax = checkTax;
            // //----------------- 

            // ReceiptXML.CheckBody checkBody = new();
            // List<ReceiptXML.CheckBody.Body> bodies = new();

            // ReceiptXML.CheckBody.Body body = new();
            // body.Code = "1";
            // body.Name = "Послуги паркування";
            // body.UnitName = "Паркування";
            // body.Amount = 1.000F;
            // body.Price = 25.00;
            // body.Letter = "А";
            // body.Cost = 25.00;

            // bodies.Add(body);
            // checkBody.BodyRow = bodies;
            // checkbuilder.checkBody = checkBody;
            // //--------------------------------------

            // string xml = ReceiptXML.SerializeToXMLString(checkbuilder);
            // ReceiptXML.SerializeToXMLFile(checkbuilder);
            // Console.WriteLine(xml);
            #endregion

            byte i;
            string originData;
            string encryptedData;
            string decryptedData;

            //create key and initial vector
            byte[] key = new byte[24];
            byte[] vector = new byte[16];

            for (i = 0; i < 24; i++) key[i] = i;
            for (i = 0; i < 16; i++) vector[i] = i;

            //create data
            originData = "test data for Rijndael encryption and decryption";

            //execute
            encryptedData = Encrypt(originData, key, vector);
            decryptedData = Decrypt(encryptedData, key, vector);

            Console.WriteLine("origin: " + originData);
            Console.WriteLine("encrypted: " + encryptedData);
            Console.WriteLine("decrypted: " + decryptedData);
            Console.ReadKey();

            static string Encrypt(string plainText, byte[] rgbKey, byte[] rgbIV)
            {
                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                ICryptoTransform encryptor = null;

                byte[] encryptedBytes = null;
                byte[] textBytes = null;

                MemoryStream msEncrypt = null;
                CryptoStream csEncrypt = null;
                StringBuilder encryptedString = null;

                int i;

                //create byte array
                textBytes = new byte[plainText.Length];
                for (i = 0; i < plainText.Length; i++)
                {
                    textBytes[i] = (byte)plainText[i];
                }

                //create encryptor
                encryptor = rijndaelManaged.CreateEncryptor(rgbKey, rgbIV);

                //encrypt
                msEncrypt = new MemoryStream();
                csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

                //write
                csEncrypt.Write(textBytes, 0, plainText.Length);
                csEncrypt.FlushFinalBlock();

                //get encrypted array of bytes.
                encryptedBytes = msEncrypt.ToArray();

                //create string
                encryptedString = new StringBuilder(encryptedBytes.Length);
                for (i = 0; i < encryptedBytes.Length; i++)
                {
                    encryptedString.Append((char)(encryptedBytes[i]));
                }

                return encryptedString.ToString();
            }

            static string Decrypt(string encryptedText, byte[] rgbKey, byte[] rgbIV)
            {
                byte[] encryptedBytes = new byte[encryptedText.Length];
                byte[] decryptedBytes = null;

                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                ICryptoTransform decryptor = null;

                MemoryStream msDecrypt = null;
                CryptoStream csDecrypt = null;

                int i;

                StringBuilder builderDecryptedText;

                //create byte array
                for (i = 0; i < encryptedText.Length; i++)
                {
                    encryptedBytes[i] = (byte)encryptedText[i];
                }

                //create decryptor
                decryptor = rijndaelManaged.CreateDecryptor(rgbKey, rgbIV);

                //decrypt
                msDecrypt = new MemoryStream(encryptedBytes);
                csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

                //read
                decryptedBytes = new byte[encryptedText.Length];
                csDecrypt.Read(decryptedBytes, 0, decryptedBytes.Length);

                //create string
                builderDecryptedText = new StringBuilder();
                for (i = 0; i < decryptedBytes.Length; i++)
                {
                    if (0 != decryptedBytes[i]) //truncate '0' because array has always a size of x*16
                    {
                        builderDecryptedText.Append((char)(decryptedBytes[i]));
                    }
                }

                return builderDecryptedText.ToString();
            }
        }
    }
}


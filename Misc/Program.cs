
namespace FiscalService.Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }  

    class RootTeg
    {
        public CheckHead checkHead { get; set; }

        public CheckTotal checkTotal { get; set; }

        public CheckPay checkPay { get; set; }

        public CheckTax checkTax { get; set; }

        public CheckExcise checkExcise { get; set; }

        public CheckBody checkBody { get; set; }
    }

    class CheckHead
    {
        public int DocType { get; set; }
        public int DocSubType { get; set; }
        public int Ver { get; set; }
        public string UID { get; set; }
        public string TIN { get; set; }
        public string INN { get; set; }
        public string OrgName { get; set; }
        public string PointName { get; set; }
        public string PointAddr { get; set; }

        

    }
}

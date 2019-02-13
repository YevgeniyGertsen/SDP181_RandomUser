using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class People : Human
    {
        public People():base("",56)
        {}
        public People(int account):this(account, "")
        {}
        public People(int account, string IIN):this(account, IIN, DateTime.MinValue)
        {}
        public People(int account, string IIN, DateTime DOB)
        {
            Console.WriteLine("4");
            this.account = account;
            this.IIN = IIN;
            this.DOB = DOB;
        }
        public People(double balance)
        {

        }

        public int account { get; set; }
        const string docNumber = "5686d";
        readonly string passNumber = "";
        private string IIN_;
        public string IIN
        {
            get
            {
                return string.Format("{0:yyy}", IIN_);
            }
            set
            {
                //if (value.Length < 12)
                //    throw new Exception("Длина ИИн мала"); 
                 IIN_ = value;
            }
        }

        public int Index { private get; set; }
        public int Age { get; private set; }
        private DateTime DOB_;
        public DateTime DOB
        {
            get
            {
                return DOB_;
            }
            set
            {
                Age = DateTime.Now.Year - value.Year;
                DOB_ = value;
            }
        }

        public bool Test(ref int balance, out string message)
        {
            if (balance < 1000)
                message = "нищеброд";
            else
                message = "не че так";

            balance = balance * 2;

            return true;
        }


        public static int getAge()
        {
            return 20;
        }
    }
}

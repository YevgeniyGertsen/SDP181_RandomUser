using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Sales
    {
        public int BUKRS { get; set; }
        public int WERKS { get; set; }
        public int LGORT { get; set; }
        public int SALES_CHANEL { get; set; }
        public string S_CHANEL_TXT { get; set; }

        private string ID_OUT_DELIVERY_DATA_;
        public string ID_OUT_DELIVERY_DATA
        {
            get
            {
                return ID_OUT_DELIVERY_DATA_;
            }
            set
            {

                DateTime tmp;
                if (DateTime.TryParse(value, out tmp))
                {
                    ID_OUT_DELIVERY_DATA_ = string.Format("{0:dd-mm-yy}", tmp);
                }
                else
                    ID_OUT_DELIVERY_DATA_ = "";


            }
        }

    }
}

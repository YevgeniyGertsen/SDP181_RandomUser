﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class ServiceUser
    {
        public ServiceUser(string Url)
        {
            this.Url = Url;
        }

        public string Url { get; private set; }

        public string GetJsonString()
        {
            string json = "";

            HttpWebRequest request = 
                (HttpWebRequest)WebRequest.Create(Url);

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            using (Stream responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream, Encoding.UTF8);
                json =  reader.ReadToEnd();
            }

            return json;
        }
    }
}

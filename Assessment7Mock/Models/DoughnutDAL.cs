using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Assessment7Mock.Models
{
    public class DoughnutDAL
    {
        public static string GetDonut(int Id)
        {
            string url = $"https://grandcircusco.github.io/demo-apis/donuts/{Id}.json";

            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader data = new StreamReader(response.GetResponseStream());
            return data.ReadToEnd();
        }
    }
}
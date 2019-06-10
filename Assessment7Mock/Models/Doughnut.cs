using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment7Mock.Models
{
    public class Doughnut
    {
        public int Id { get;}
        public string Name { get; }
        public int Calories { get; }
        public string PhotoURL { get; }
        public List<string> Extras { get; }

        public Doughnut(string data)
        {
            JObject donutData = JObject.Parse(data);

            Id = (int)donutData["id"];
            Name = donutData["name"].ToString();
            Calories = (int)donutData["calories"];

        }
    }
}
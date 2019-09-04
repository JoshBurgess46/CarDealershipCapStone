using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipCapstoneAPI.Models
{


    //public class Rootobject
    //{
    //    public Class1[] Property1 { get; set; }
    //}

    public class CarInfo
    {
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
    }


}

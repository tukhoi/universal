using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davang.Enterprise;
using Davang.Enterprise.Portable;

namespace NewsExplorer.Models.Portable
{
    public class Location : Entity
    {
        public string city { get; set; }
        public string country { get; set; }
        public float latitude { get; set; }
        public float longtitude { get; set; }
        public string name { get; set; }
        public string region { get; set; }
        public string state { get; set; }
        public string street { get; set; }
        public string zip { get; set; }

        //public MappedProperty<string> City = new MappedProperty<string>("city");
        //public MappedProperty<string> Country = new MappedProperty<string>("country");
        //public MappedProperty<float> Latitude = new MappedProperty<float>("latitude");
        //public MappedProperty<float> Longtitude = new MappedProperty<float>("longtitude");
        //public MappedProperty<string> Name = new MappedProperty<string>("name");
        //public MappedProperty<string> Region = new MappedProperty<string>("region");
        //public MappedProperty<string> State = new MappedProperty<string>("state");
        //public MappedProperty<string> Street = new MappedProperty<string>("street");
        //public MappedProperty<string> Zip = new MappedProperty<string>("zip");
    }
}

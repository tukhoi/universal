using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davang.Enterprise;
using Davang.Enterprise.Portable;

namespace NewsExplorer.Models.Portable
{
    public class MallingAddress : Entity
    {
        public string city { get; set; }
        public Page city_page { get; set; }
        public string country { get; set; }
        public string postal_code { get; set; }
        public string region { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }

        //public MappedProperty<string> City = new MappedProperty<string>("city");
        //public MappedProperty<Page> Page = new MappedProperty<Page>("city_page");
        //public MappedProperty<string> Country = new MappedProperty<string>("country");
        //public MappedProperty<string> PostalCode = new MappedProperty<string>("postal_code");
        //public MappedProperty<string> Region = new MappedProperty<string>("region");
        //public MappedProperty<string> Street1 = new MappedProperty<string>("street1");
        //public MappedProperty<string> Street2 = new MappedProperty<string>("street2");
    }
}

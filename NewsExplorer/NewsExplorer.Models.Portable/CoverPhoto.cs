using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davang.Enterprise.Portable;

namespace NewsExplorer.Models.Portable
{
    public class CoverPhoto : Entity
    {
        public float offset_x { get; set; }
        public float offset_y { get; set; }
        public string source { get; set; }
    }
}

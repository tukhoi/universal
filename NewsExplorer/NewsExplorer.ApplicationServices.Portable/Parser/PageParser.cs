using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsExplorer.Models.Portable;
using Newtonsoft.Json;

namespace NewsExplorer.ApplicationServices.Portable.Parser
{
    public class PageParser : IParser
    {
        public Page Parse<Page>(string rawResult)
        {
            var page = JsonConvert.DeserializeObject<Page>(rawResult);
            return page;
        }
    }
}

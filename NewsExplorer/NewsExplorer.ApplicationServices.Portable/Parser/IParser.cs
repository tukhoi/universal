using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsExplorer.ApplicationServices.Portable.Parser
{
    public interface IParser
    {
        T Parse<T>(string rawResult);
    }
}

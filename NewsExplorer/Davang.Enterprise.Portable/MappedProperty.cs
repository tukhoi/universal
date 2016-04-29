using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davang.Enterprise.Portable
{
    public interface IMappedProperty
    {
        string RemoteName { get; set; }
    }

    public class MappedProperty<T> : IMappedProperty
    {
        public T Name { get; set; }
        public string RemoteName { get; set; }

        public MappedProperty(string remoteName)
        {
            RemoteName = remoteName;
        }
    }
}

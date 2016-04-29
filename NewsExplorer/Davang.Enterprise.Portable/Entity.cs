using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davang.Enterprise.Portable
{
    public class EntityWithId<T>
    {
        MappedProperty<T> Id { get; set; }
    }

    public class Entity : EntityWithId<string>
    { }
}

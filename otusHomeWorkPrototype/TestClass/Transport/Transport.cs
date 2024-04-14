using otusHomeWorkPrototype.Prototype;
using otusHomeWorkPrototype.TestClass.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Transport
{
    public abstract class Transport : IMyCloneable<Transport>
    {
        public decimal Speed { get; set; }

        public abstract object Clone();
        public abstract Transport DeepClone();
        public abstract Transport ShallowClone();
    }
}

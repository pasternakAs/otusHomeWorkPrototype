using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Transport
{
    public class Ship : Transport
    {
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override Transport DeepClone()
        {
            throw new NotImplementedException();
        }

        public override Transport ShallowClone()
        {
            throw new NotImplementedException();
        }
    }
}

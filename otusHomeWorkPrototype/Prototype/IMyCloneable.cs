using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.Prototype
{
    interface IMyCloneable<T> : ICloneable
    {
        public T ShallowClone();
        public T DeepClone();
    }
}

using otusHomeWorkPrototype.Prototype;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    public abstract class DocumentClass : IMyCloneable<DocumentClass>
    {
        public string NumDocument { get; set; }
        public string DateDocument { get; set; }

        public abstract DocumentClass ShallowClone();
        public abstract DocumentClass DeepClone();

        public abstract object Clone();
    }
}

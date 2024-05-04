using otusHomeWorkPrototype.TestClass.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Transport
{
    public class AutoClass : Transport
    {
        //Машины

        public string Brand { get; set; }

        public AutoClass()
        {

        }

        public override object Clone()
        {
            return DeepClone();
        }

        public override AutoClass DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<AutoClass>(serialized);

            return copy;
        }

        public override AutoClass ShallowClone()
        {
            return (AutoClass)MemberwiseClone();
        }
    }
}

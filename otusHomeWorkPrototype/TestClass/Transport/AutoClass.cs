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
        public string Brand { get; set; }

        public AutoClass(decimal speed, string brand)
        {
            Speed = speed;
            Brand = brand;
        }

        public override object Clone()
        {
            return DeepClone();
        }

        public override Transport DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<AutoClass>(serialized);

            return copy;
        }

        public override Transport ShallowClone()
        {
            throw new NotImplementedException();
        }
    }
}

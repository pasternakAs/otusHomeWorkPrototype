using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    public class WaybillClass : DocumentClass
    {
        public WaybillClass()
        {
             
        }

        public override WaybillClass ShallowClone()
        {
            return (WaybillClass)MemberwiseClone();
        }

        public override WaybillClass DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<WaybillClass>(serialized);

            return copy;
        }

        public override object Clone()
        {
            return DeepClone();
        }
    }
}
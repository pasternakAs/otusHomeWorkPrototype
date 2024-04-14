using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    public class PaymentDocumentClass : DocumentClass
    {
        public override PaymentDocumentClass ShallowClone()
        {
            return (PaymentDocumentClass)MemberwiseClone();
        }

        public override PaymentDocumentClass DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<PaymentDocumentClass>(serialized);

            return copy;
        }

        public override object Clone()
        {
            return DeepClone();
        }
    }
}

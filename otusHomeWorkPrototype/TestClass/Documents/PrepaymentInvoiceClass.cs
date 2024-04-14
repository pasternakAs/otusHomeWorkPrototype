using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    public class PrepaymentInvoiceClass : DocumentClass
    {
        public List<DocumentRowsClass> DocumentRows { get; set; }
        public PrepaymentInvoiceClass()
        {
                
        }

        public override DocumentClass ShallowClone()
        {
            return (PrepaymentInvoiceClass)MemberwiseClone();
        }

        public override DocumentClass DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<PrepaymentInvoiceClass>(serialized);

            return copy;
        }

        public override object Clone()
        {
            return DeepClone();
        }
    }
}

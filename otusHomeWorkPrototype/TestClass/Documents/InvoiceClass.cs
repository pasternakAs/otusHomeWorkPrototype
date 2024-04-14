using System.Text.Json;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    public class InvoiceClass : DocumentClass
    {
        public PaymentDocumentClass PaymentDocument { get; set; }

        public override InvoiceClass ShallowClone()
        {
            return (InvoiceClass)MemberwiseClone();
        }

        public override InvoiceClass DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<InvoiceClass>(serialized);

            return copy;
        }

        public override object Clone()
        {
            return DeepClone();
        }
    }
}

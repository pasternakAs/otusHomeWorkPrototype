using System.Reflection;
using System.Text.Json;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    //счет-фактура с датой  и № документа
    //BankDetails реквизиты банка
    //PaymentDocumentClass Реквизиты платежного поручения

    [Serializable]
    public class InvoiceClass : DocumentClass
    {
        public PaymentDocumentClass PaymentDocument { get; set; }
        public BankDetails BankDetails { get; set; }

        public InvoiceClass()
        {
            PaymentDocument = new PaymentDocumentClass
            {
                DateDocument = DateTime.Now.ToShortDateString(),
                NumDocument = "1"
            };

            BankDetails = new BankDetails
            {
                Name = "AlfaOmegaBank",
            };
        }

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


        public void PrintDetails() =>
            Console.WriteLine(
                $"\nNumDocument: {NumDocument}" +
                $"\nDateDocument: {DateDocument}" +
                $"\nPaymentDocument Num: {PaymentDocument.NumDocument}" +
                $"\nPaymentDocument Date: {PaymentDocument.DateDocument}" +
                $"\nBank Name: {BankDetails.Name}");
    }
}

// See https://aka.ms/new-console-template for more information
using otusHomeWorkPrototype.TestClass.Documents;

Console.WriteLine("Начнем!");

var document = new WaybillClass() { NumDocument = "0", DateDocument = DateTime.Now.ToShortDateString()};
var documentCopy = document.DeepClone();


bool isTheSameInstance = object.ReferenceEquals(document, documentCopy);
if(!isTheSameInstance) Console.WriteLine("Объект успешно скопирован!");

var documentInvoice = new InvoiceClass() { NumDocument = "0", DateDocument = DateTime.Now.ToShortDateString(), PaymentDocument = new PaymentDocumentClass() };
var documentInvoiceCopy = documentInvoice.DeepClone();


isTheSameInstance = object.ReferenceEquals(documentInvoice.PaymentDocument, documentInvoiceCopy.PaymentDocument); // false
if (!isTheSameInstance) Console.WriteLine("Объект успешно скопирован!");

Console.WriteLine("Конец!");
Console.ReadLine();
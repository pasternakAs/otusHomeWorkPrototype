// See https://aka.ms/new-console-template for more information
using otusHomeWorkPrototype.TestClass.Documents;
using otusHomeWorkPrototype.TestClass.Transport;

Console.WriteLine("Начнем!");

var transportShip = new Ship();
var transportShipDeepClone = transportShip.DeepClone();
var transportShipShallowClone = transportShip.ShallowClone();

var document = new WaybillClass() { NumDocument = "0", DateDocument = DateTime.Now.ToShortDateString() };
var documentDc = document.DeepClone();
var documentSc = document.ShallowClone();

bool isTheSameInstance = object.ReferenceEquals(document, documentDc);
if (!isTheSameInstance) Console.WriteLine("Объект успешно скопирован!");

var documentInvoice = new InvoiceClass()
{
    NumDocument = "1",
    DateDocument = DateTime.Now.ToShortDateString()
};
documentInvoice.PrintDetails();

var documentInvoiceDc = documentInvoice.DeepClone();
isTheSameInstance = object.ReferenceEquals(documentInvoice, documentInvoiceDc) && object.ReferenceEquals(documentInvoice.PaymentDocument, documentInvoiceDc.PaymentDocument); // false
if (!isTheSameInstance) Console.WriteLine("Объект успешно скопирован!");


var documentInvoiceSc = documentInvoice.ShallowClone();
documentInvoice.NumDocument = "7";
documentInvoice.PaymentDocument.NumDocument = "3";

isTheSameInstance = object.ReferenceEquals(documentInvoice.PaymentDocument, documentInvoiceSc.PaymentDocument); // false
if (!isTheSameInstance) Console.WriteLine("Объект успешно скопирован!");
else 
{
    Console.WriteLine("Объект не скопирован!");
    Console.WriteLine("Скопированный объект: ");
    documentInvoiceSc.PrintDetails();
}


var documentInvoiceClone = documentInvoice.Clone();
isTheSameInstance = object.ReferenceEquals(documentInvoice, documentInvoiceClone); // false
if (!isTheSameInstance) Console.WriteLine("Объект успешно скопирован!");

Console.WriteLine("Конец!");
Console.ReadLine();
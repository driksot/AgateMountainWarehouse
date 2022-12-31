using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IInvoiceHttpRepository
{
    Task GenerateInvoice(InvoiceViewModel invoice);
}

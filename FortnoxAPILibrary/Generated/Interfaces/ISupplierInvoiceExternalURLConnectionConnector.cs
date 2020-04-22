using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface ISupplierInvoiceExternalURLConnectionConnector : IConnector
	{
        [SearchParameter("filter")]
		Filter.SupplierInvoiceExternalURLConnection? FilterBy { get; set; }

		SupplierInvoiceExternalURLConnection Update(SupplierInvoiceExternalURLConnection supplierInvoiceExternalURLConnection);

		SupplierInvoiceExternalURLConnection Create(SupplierInvoiceExternalURLConnection supplierInvoiceExternalURLConnection);

		SupplierInvoiceExternalURLConnection Get(int? id);

		void Delete(int? id);

		EntityCollection<SupplierInvoiceExternalURLConnection> Find();

	}
}
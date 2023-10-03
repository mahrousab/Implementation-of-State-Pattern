

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class UnpaidState : IInvoiceState
{
	public void Pay(Invoice invoice)
	{
		Console.WriteLine($"Paying invoice {invoice.Number}...");

	}

	public void Cancel(Invoice invoice)
	{
		Console.WriteLine($"Canceling invoice {invoice.Number}...");

	}

	public void Refund(Invoice invoice)
	{
		Console.WriteLine($"Invoice {invoice.Number} is unpaid and cannot be refunded.");

	}
}
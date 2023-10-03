using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
	public class PaidState : IInvoiceState
	{

		public void Pay(Invoice invoice)
		{
			Console.WriteLine($"Invoice {invoice.Number} has already been paid.");
		}

		public void Cancel(Invoice invoice)
		{
			Console.WriteLine($"Invoice {invoice.Number} cannot be cancelled.");
		}

		public void Refund(Invoice invoice)
		{
			Console.WriteLine($"Invoice {invoice.Number} has been refunded.");
		}
	}
}

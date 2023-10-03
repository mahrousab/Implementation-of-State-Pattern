using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
	public class CanseldState: IInvoiceState
	{

		public void Pay(Invoice invoice)
		{
			Console.WriteLine($"Invoice {invoice.Number} has been canceled and cannot be paid.");
		}

		public void Cancel(Invoice invoice)
		{
			Console.WriteLine($"Invoice {invoice.Number} has already been canceled and cannot be canceled again.");
		}

		public void Refund(Invoice invoice)
		{
			Console.WriteLine($"Invoice {invoice.Number} has been canceled and cannot be refunded.");
		}
	}
}

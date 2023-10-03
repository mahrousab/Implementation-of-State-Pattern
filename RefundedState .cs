using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States
{
	
		public class RefundedState : IInvoiceState
		{
			public void Cancel(Invoice invoice)
			{
				Console.WriteLine($"Invoice {invoice.Number} was refunded and cannot be cancelled.");

			}
			public void Pay(Invoice invoice)
			{
				Console.WriteLine($"Invoice {invoice.Number} was refunded and cannot be paid.");

			}
			public void Refund(Invoice invoice)
			{
				Console.WriteLine($"Invoice {invoice.Number} cannot be refunded again.");
			}
		}
	}


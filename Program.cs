public class Program
{
	public static void Main(string[] args)
	{
		var invoice = new Invoice(123, 1000m, "Software Dev Services");

		invoice.Pay();
		invoice.Refund();
	}
}
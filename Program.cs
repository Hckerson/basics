
namespace MyApp.Payments;

public interface IpaymentProcessor
{
	bool ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IpaymentProcessor
{
	public bool ProcessPayment(decimal amount)
	{
		Console.WriteLine("Processing credit card payment of $" + amount);
		return true;
	}

}

public record PaymentResult(bool Success, string? TransactionId);

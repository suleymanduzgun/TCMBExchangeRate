namespace TCMBExchangeRate.Models;

public class CurrencyCodeNameModel
{
	public string CurrencyName { get; set; }
	public string CurrencyCode { get; set; }

	public CurrencyCodeNameModel() { }

	public CurrencyCodeNameModel(string currencyName, string currencyCode)
	{
		CurrencyName = currencyName;
		CurrencyCode = currencyCode;
	}
}

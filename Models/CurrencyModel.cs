namespace TCMBExchangeRate.Models;

public class CurrencyModel
{
	public string Name { get; }
	public string Code { get; }
	public string CrossCode { get; }
	public decimal? ForexBuying { get; }
	public decimal? ForexSelling { get; }
	public decimal? BanknoteBuying { get; }
	public decimal? BanknoteSelling { get; }

	public CurrencyModel() { }

	public CurrencyModel(string name, string code, string crossCode, decimal? forexBuying, decimal? forexSelling, decimal? banknoteBuying, decimal? banknoteSelling)
	{
		Name = name;
		Code = code;
		CrossCode = crossCode;
		ForexBuying = forexBuying;
		ForexSelling = forexSelling;
		BanknoteBuying = banknoteBuying;
		BanknoteSelling = banknoteSelling;
	}
}

using TCMBExchangeRate.Models;

namespace TCMBExchangeRate;

public interface ITCMBExchangeRateService
{
	/// <summary>
	/// Get the list of currencies listed in TCMB xml web page
	/// </summary>
	/// <returns></returns>
	Task<List<CurrencyCodeNameModel>> GetNameCodeListAsync();

	/// <summary>
	/// Get today's exchange rates listed in TCMB xml web page
	/// </summary>
	/// <returns></returns>
	Task<List<CurrencyModel>> GetTodaysExchangeRateList();
}

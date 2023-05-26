using TCMBExchangeRate.Helpers;
using TCMBExchangeRate.Models;

namespace Core.TCMBExchangeRate.Helper;

public class TCMBEnumToListHelper
{
	public static List<CurrencyCodeNameModel> ToNameCodeList<T>() where T : Enum
	{
		return Enum.GetValues(typeof(T))
				.Cast<T>()
				.Select(item => new CurrencyCodeNameModel { CurrencyName = item.ToString(), CurrencyCode = item.GetTCMBEnumDescription() })
				.ToList();
	}


	public static async Task<List<CurrencyCodeNameModel>> ToNameCodeListAsync<T>() where T : Enum
	{
		return await Task.Run(() => Enum.GetValues(typeof(T))
			 .Cast<T>()
			 .Select(item => new CurrencyCodeNameModel { CurrencyName = item.ToString(), CurrencyCode = item.GetTCMBEnumDescription() })
			 .ToList());
	}
}

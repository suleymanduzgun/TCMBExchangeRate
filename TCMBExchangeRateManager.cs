using Core.TCMBExchangeRate.Helper;
using static TCMBExchangeRate.Enums.TCMBEnums;
using System.Xml;
using TCMBExchangeRate.Models;
using TCMBExchangeRate.Helpers;

namespace TCMBExchangeRate;


public class TCMBExchangeRateManager : ITCMBExchangeRateService
{
	private static readonly string tcmbBaseLink = "http://www.tcmb.gov.tr/kurlar/";
	public async Task<List<CurrencyCodeNameModel>> GetNameCodeListAsync() => await TCMBEnumToListHelper.ToNameCodeListAsync<CurrencyCodeEnums>();

	public async Task<List<CurrencyModel>> GetTodaysExchangeRateList() => await GetCurrencyRateList($"{tcmbBaseLink}today.xml");



	private static async Task<List<CurrencyModel>> GetCurrencyRateList(string link)
	{
		try
		{
			await Task.Yield();
			XmlTextReader? xmlTextReader = new(link);
			// XmlTextReader nesnesini yaratıyoruz ve parametre olarak xml dokümanın urlsini veriyoruz
			// XmlTextReader urlsi belirtilen xml dokümanlarına hızlı ve forward-only giriş imkanı sağlar.
			XmlDocument? xmlDocument = new();
			// XmlDocument nesnesini yaratıyoruz.
			xmlDocument.Load(xmlTextReader);
			// Load metodu ile xml yüklüyoruz
			XmlNode? _date = xmlDocument.SelectSingleNode("/Tarih_Date/@Tarih");
			XmlNodeList? _currency = xmlDocument.SelectNodes("/Tarih_Date/Currency");
			XmlNodeList? _name = xmlDocument.SelectNodes("/Tarih_Date/Currency/Isim");
			XmlNodeList? _code = xmlDocument.SelectNodes("/Tarih_Date/Currency/@Kod");
			XmlNodeList? _forexBuying = xmlDocument.SelectNodes("/Tarih_Date/Currency/ForexBuying");
			XmlNodeList? _forexSelling = xmlDocument.SelectNodes("/Tarih_Date/Currency/ForexSelling");
			XmlNodeList? _banknoteBuying = xmlDocument.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
			XmlNodeList? _banknoteSelling = xmlDocument.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");

			List<CurrencyModel> ExchangeRates = new() { new CurrencyModel($"{CurrencyCodeEnums.TRY.GetTCMBEnumDescription()}", $"{CurrencyCodeEnums.TRY}", $"{CurrencyCodeEnums.TRY}/{CurrencyCodeEnums.TRY}", 1, 1, 1, 1) };

			for (int i = 0; i < _name.Count; i++)
			{
				string name = _name?.Item(i)?.InnerText?.ToString() ?? string.Empty;
				if (name == string.Empty) break;

				string code = _code?.Item(i)?.InnerText?.ToString() ?? string.Empty;
				string crossCodee = _code?.Item(i)?.InnerText?.ToString() + $"/{CurrencyCodeEnums.TRY}";
				decimal? forexBuying = string.IsNullOrEmpty(_forexBuying?.Item(i)?.InnerText?.ToString()) ? null : Convert.ToDecimal(_forexBuying?.Item(i)?.InnerText?.ToString());
				decimal? forexSelling = string.IsNullOrEmpty(_forexSelling?.Item(i)?.InnerText?.ToString()) ? null : Convert.ToDecimal(_forexSelling?.Item(i)?.InnerText?.ToString());
				decimal? banknoteBuying = string.IsNullOrEmpty(_banknoteBuying?.Item(i)?.InnerText?.ToString()) ? null : Convert.ToDecimal(_banknoteBuying?.Item(i)?.InnerText?.ToString());
				decimal? banknoteSelling = string.IsNullOrEmpty(_banknoteSelling?.Item(i)?.InnerText?.ToString()) ? null : Convert.ToDecimal(_banknoteSelling?.Item(i)?.InnerText?.ToString());

				ExchangeRates.Add(new CurrencyModel(name, code, crossCodee, forexBuying, forexSelling, banknoteBuying, banknoteSelling));
			}

			return ExchangeRates;
		}
		catch (Exception ex)
		{
			throw new Exception("Hata: " + ex.Message);
		}
	}
}

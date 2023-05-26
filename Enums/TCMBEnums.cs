using System.ComponentModel;

namespace TCMBExchangeRate.Enums;

public class TCMBEnums
{
	public enum ExchangeTypeEnum
	{
		[Description("Döviz Alış")]
		ForexBuying = 0,

		[Description("Döviz Satış")]
		ForexSelling = 1,

		[Description("Efektif Alış")]
		BanknoteBuying = 2,

		[Description("Efektif Satış")]
		BanknoteSelling = 3
	}

	public enum CurrencyCodeEnums
	{
		[Description("TÜRK LİRASI")]
		TRY = 0,

		[Description("ABD DOLARI")]
		USD = 1,

		[Description("AVUSTRALYA DOLARI")]
		AUD = 2,

		[Description("DANİMARKA KRONU")]
		DKK = 3,

		[Description("EURO")]
		EUR = 4,

		[Description("İNGİLİZ STERLİNİ")]
		GBP = 5,

		[Description("İSVİÇRE FRANGI")]
		CHF = 6,

		[Description("İSVEÇ KRONU")]
		SEK = 7,

		[Description("KANADA DOLARI")]
		CAD = 8,

		[Description("KUVEYT DİNARI")]
		KWD = 9,

		[Description("NORVEÇ KRONU")]
		NOK = 10,

		[Description("SUUDİ ARABİSTAN RİYALİ")]
		SAR = 11,

		[Description("JAPON YENİ")]
		JPY = 12,

		[Description("BULGAR LEVASI")]
		BGN = 13,

		[Description("RUMEN LEYİ")]
		RON = 14,

		[Description("RUS RUBLESİ")]
		RUB = 15,

		[Description("İRAN RİYALİ")]
		IRR = 16,

		[Description("ÇİN YUANI")]
		CNY = 17,

		[Description("PAKİSTAN RUPİSİ")]
		PKR = 18,

		[Description("KATAR RİYALİ")]
		QAR = 19,

		[Description("GÜNEY KORE WONU")]
		KRW = 20,

		[Description("AZERBAYCAN YENİ MANATI")]
		AZN = 21,

		[Description("BİRLEŞİK ARAP EMİRLİKLERİ DİRHEMİ")]
		AED = 22
	}
}

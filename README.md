# TCMBExchangeRate
Türkiye Cumhuriyeti Merkez Bankası Döviz Kurları

Şimdilik iki tane servisi mevcut. Bir tanesi MB sitesinde listenene para birimlerinin listesini getiren servis, diğeri de bu para birimlerinin TL karşısındaki bugünkü kur listesini getiren servis.
Talep edilen gün bir resmi tatil gününe denk gelirse boş data döner. Geliştirilmeye açık, destek olmak isteyenler katkıda bulunabilirler.

KURULUM

1 - Nuget paketi kurulumu yapılır.

2 - Projenizde Dependency Injection yapılan yerde tanımı yapılır. Örnek kullanım: 

    services.AddSingleton<ITCMBExchangeRateService, TCMBExchangeRateManager>();
    
3 - İlgili sayfaya using satırı eklendikten sonra kullanıma hazır.

    using TCMBExchangeRate;
    
    
KULLANIM:

İlgili sayfaya "using TCMBExchangeRate;" satırı eklendikten sonra:

    var currencyList = await _tcmbRateService.GetNameCodeListAsync();

    var todaysExchangeRateList = await _tcmbRateService.GetTodaysExchangeRateList();

ile para listesi ve günün kur listesi gelmektedir.

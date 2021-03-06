# Intrinio.SDK.Api.ForexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetForexCurrencies**](ForexApi.md#getforexcurrencies) | **GET** /forex/currencies | Forex Currencies
[**GetForexPairs**](ForexApi.md#getforexpairs) | **GET** /forex/pairs | Forex Currency Pairs
[**GetForexPrices**](ForexApi.md#getforexprices) | **GET** /forex/prices/{pair}/{timeframe} | Forex Currency Prices


<a name="getforexcurrencies"></a>
# **GetForexCurrencies**
> ApiResponseForexCurrencies GetForexCurrencies ()

Forex Currencies

Returns a list of forex currencies for which prices are available.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetForexCurrenciesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var forexApi = new ForexApi();

            try
            {
                ApiResponseForexCurrencies result = forexApi.GetForexCurrencies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForexApi.GetForexCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiResponseForexCurrencies**](ApiResponseForexCurrencies.md)

<a name="getforexpairs"></a>
# **GetForexPairs**
> ApiResponseForexPairs GetForexPairs ()

Forex Currency Pairs

Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetForexPairsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var forexApi = new ForexApi();

            try
            {
                ApiResponseForexPairs result = forexApi.GetForexPairs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForexApi.GetForexPairs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiResponseForexPairs**](ApiResponseForexPairs.md)

<a name="getforexprices"></a>
# **GetForexPrices**
> ApiResponseForexPrices GetForexPrices (string pair, string timeframe, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)

Forex Currency Prices

Provides a list of forex price quotes for a given forex currency pair and timeframe.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetForexPricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var forexApi = new ForexApi();
            var pair = "EURUSD";  // string | The Forex Currency Pair code
            var timeframe = "D1";  // string | The time interval for the quotes
            var timezone = "UTC";  // string | Returns trading times in this timezone (optional)  (default to UTC)
            var startDate = "2018-01-01";  // string | Return Forex Prices on or after this date (optional) 
            var startTime = "14:20:00";  // string | Return Forex Prices at or after this time (24-hour) (optional) 
            var endDate = "2019-01-01";  // string | Return Forex Prices on or before this date (optional) 
            var endTime = "21:01:21";  // string | Return Forex Prices at or before this time (24-hour) (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseForexPrices result = forexApi.GetForexPrices(pair, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForexApi.GetForexPrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | **string**| The Forex Currency Pair code | 
 **timeframe** | **string**| The time interval for the quotes | 
 **timezone** | **string**| Returns trading times in this timezone | [optional] [default to UTC]
 **startDate** | **string**| Return Forex Prices on or after this date | [optional] 
 **startTime** | **string**| Return Forex Prices at or after this time (24-hour) | [optional] 
 **endDate** | **string**| Return Forex Prices on or before this date | [optional] 
 **endTime** | **string**| Return Forex Prices at or before this time (24-hour) | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseForexPrices**](ApiResponseForexPrices.md)


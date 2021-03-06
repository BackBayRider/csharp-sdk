# Intrinio.SDK.Api.StockExchangeApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllStockExchanges**](StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | All Stock Exchanges
[**GetStockExchangeById**](StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Lookup Stock Exchange
[**GetStockExchangePriceAdjustments**](StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Stock Price Adjustments by Exchange
[**GetStockExchangePrices**](StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Stock Prices by Exchange
[**GetStockExchangeRealtimePrices**](StockExchangeApi.md#getstockexchangerealtimeprices) | **GET** /stock_exchanges/{identifier}/prices/realtime | Realtime Stock Prices by Exchange
[**GetStockExchangeSecurities**](StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Securities by Exchange


<a name="getallstockexchanges"></a>
# **GetAllStockExchanges**
> ApiResponseStockExchanges GetAllStockExchanges (string city = null, string country = null, string countryCode = null, decimal? pageSize = null)

All Stock Exchanges

Returns all Stock Exchanges. Returns Stock Exchanges matching parameters when specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllStockExchangesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var city = city_example;  // string | Filter by city (optional) 
            var country = "CHINA";  // string | Filter by country (optional) 
            var countryCode = countryCode_example;  // string | Filter by ISO country code (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseStockExchanges result = stockExchangeApi.GetAllStockExchanges(city, country, countryCode, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetAllStockExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **city** | **string**| Filter by city | [optional] 
 **country** | **string**| Filter by country | [optional] 
 **countryCode** | **string**| Filter by ISO country code | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseStockExchanges**](ApiResponseStockExchanges.md)

<a name="getstockexchangebyid"></a>
# **GetStockExchangeById**
> StockExchange GetStockExchangeById (string identifier)

Lookup Stock Exchange

Returns the Stock Exchange with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockExchangeByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = "XSHG";  // string | A Stock Exchange identifier (MIC or Intrinio ID)

            try
            {
                StockExchange result = stockExchangeApi.GetStockExchangeById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 

### Return type

[**StockExchange**](StockExchange.md)

<a name="getstockexchangepriceadjustments"></a>
# **GetStockExchangePriceAdjustments**
> ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, decimal? pageSize = null, string nextPage = null)

Stock Price Adjustments by Exchange

Returns stock price adjustments for the Stock Exchange with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockExchangePriceAdjustmentsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var date = "2018-08-14";  // DateTime? | The date for which to return price adjustments (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockExchangeStockPriceAdjustments result = stockExchangeApi.GetStockExchangePriceAdjustments(identifier, date, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangePriceAdjustments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **date** | **DateTime?**| The date for which to return price adjustments | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockExchangeStockPriceAdjustments**](ApiResponseStockExchangeStockPriceAdjustments.md)

<a name="getstockexchangeprices"></a>
# **GetStockExchangePrices**
> ApiResponseStockExchangeStockPrices GetStockExchangePrices (string identifier, DateTime? date = null, decimal? pageSize = null, string nextPage = null)

Stock Prices by Exchange

Returns end-of-day stock prices for Securities on the Stock Exchange with `identifier` and on the `price_date` (or the latest date that prices are available)

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockExchangePricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var date = "2018-08-14";  // DateTime? | The date for which to return prices (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockExchangeStockPrices result = stockExchangeApi.GetStockExchangePrices(identifier, date, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangePrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **date** | **DateTime?**| The date for which to return prices | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockExchangeStockPrices**](ApiResponseStockExchangeStockPrices.md)

<a name="getstockexchangerealtimeprices"></a>
# **GetStockExchangeRealtimePrices**
> ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, string source = null, decimal? pageSize = null, string nextPage = null)

Realtime Stock Prices by Exchange

Returns realtime stock prices for the Stock Exchange with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockExchangeRealtimePricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var source = "";  // string | Return realtime prices from the specified data source (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockExchangeRealtimeStockPrices result = stockExchangeApi.GetStockExchangeRealtimePrices(identifier, source, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeRealtimePrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **source** | **string**| Return realtime prices from the specified data source | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockExchangeRealtimeStockPrices**](ApiResponseStockExchangeRealtimeStockPrices.md)

<a name="getstockexchangesecurities"></a>
# **GetStockExchangeSecurities**
> ApiResponseStockExchangeSecurities GetStockExchangeSecurities (string identifier, decimal? pageSize = null, string nextPage = null)

Securities by Exchange

Returns Securities traded on the Stock Exchange with `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockExchangeSecuritiesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockExchangeSecurities result = stockExchangeApi.GetStockExchangeSecurities(identifier, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeSecurities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockExchangeSecurities**](ApiResponseStockExchangeSecurities.md)


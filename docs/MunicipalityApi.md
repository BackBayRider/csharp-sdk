# Intrinio.SDK.Api.MunicipalityApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllMunicipalities**](MunicipalityApi.md#getallmunicipalities) | **GET** /municipalities | All Municipalities
[**GetMunicipalityById**](MunicipalityApi.md#getmunicipalitybyid) | **GET** /municipalities/{id} | Municipality by ID
[**GetMunicipalityFinancials**](MunicipalityApi.md#getmunicipalityfinancials) | **GET** /municipalities/{id}/financials | Financials for a Municipality


<a name="getallmunicipalities"></a>
# **GetAllMunicipalities**
> ApiResponseMunicipalities GetAllMunicipalities (bool? hasFinancials = null, string governmentName = null, string governmentType = null, string areaName = null, string areaType = null, string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null, decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null, decimal? enrollmentLessThan = null, string nextPage = null)

All Municipalities

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllMunicipalitiesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var municipalityApi = new MunicipalityApi();
            var hasFinancials = true;  // bool? | Return municipalities with financials (optional) 
            var governmentName = governmentName_example;  // string | Return municipalities with a government name matching the given query (optional) 
            var governmentType = governmentType_example;  // string | Return municipalities with the given government type (optional) 
            var areaName = areaName_example;  // string | Return municipalities with an area name matching the given query (optional) 
            var areaType = areaType_example;  // string | Return municipalities with the given area type (optional) 
            var city = city_example;  // string | Return municipalities in the given city (optional) 
            var state = state_example;  // string | Return municipalities in the given state (optional) 
            var zipcode = 8.14;  // decimal? | Return municipalities in the given zipcode (optional) 
            var populationGreaterThan = 8.14;  // decimal? | Return municipalities with a population greater than the given number (optional) 
            var populationLessThan = 8.14;  // decimal? | Return municipalities with a population less than the given number (optional) 
            var enrollmentGreaterThan = 8.14;  // decimal? | Return municipalities with an enrollment greater than the given number (optional) 
            var enrollmentLessThan = 8.14;  // decimal? | Return municipalities with an enrollment less than the given number (optional) 
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseMunicipalities result = municipalityApi.GetAllMunicipalities(hasFinancials, governmentName, governmentType, areaName, areaType, city, state, zipcode, populationGreaterThan, populationLessThan, enrollmentGreaterThan, enrollmentLessThan, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MunicipalityApi.GetAllMunicipalities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hasFinancials** | **bool?**| Return municipalities with financials | [optional] 
 **governmentName** | **string**| Return municipalities with a government name matching the given query | [optional] 
 **governmentType** | **string**| Return municipalities with the given government type | [optional] 
 **areaName** | **string**| Return municipalities with an area name matching the given query | [optional] 
 **areaType** | **string**| Return municipalities with the given area type | [optional] 
 **city** | **string**| Return municipalities in the given city | [optional] 
 **state** | **string**| Return municipalities in the given state | [optional] 
 **zipcode** | **decimal?**| Return municipalities in the given zipcode | [optional] 
 **populationGreaterThan** | **decimal?**| Return municipalities with a population greater than the given number | [optional] 
 **populationLessThan** | **decimal?**| Return municipalities with a population less than the given number | [optional] 
 **enrollmentGreaterThan** | **decimal?**| Return municipalities with an enrollment greater than the given number | [optional] 
 **enrollmentLessThan** | **decimal?**| Return municipalities with an enrollment less than the given number | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseMunicipalities**](ApiResponseMunicipalities.md)

<a name="getmunicipalitybyid"></a>
# **GetMunicipalityById**
> Municipality GetMunicipalityById (string id)

Municipality by ID

Returns the Municipality with the given ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetMunicipalityByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var municipalityApi = new MunicipalityApi();
            var id = "mun_Xn7x4z";  // string | An Intrinio ID of a Municipality

            try
            {
                Municipality result = municipalityApi.GetMunicipalityById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MunicipalityApi.GetMunicipalityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| An Intrinio ID of a Municipality | 

### Return type

[**Municipality**](Municipality.md)

<a name="getmunicipalityfinancials"></a>
# **GetMunicipalityFinancials**
> ApiResponseMunicipalitiyFinancials GetMunicipalityFinancials (string id, decimal? fiscalYear = null)

Financials for a Municipality

Returns financial statement data for the Municipality with the given ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetMunicipalityFinancialsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var municipalityApi = new MunicipalityApi();
            var id = "mun_Xn7x4z";  // string | An Intrinio ID of a Municipality
            var fiscalYear = 8.14;  // decimal? | Return financials for the given fiscal year (optional) 

            try
            {
                ApiResponseMunicipalitiyFinancials result = municipalityApi.GetMunicipalityFinancials(id, fiscalYear);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MunicipalityApi.GetMunicipalityFinancials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| An Intrinio ID of a Municipality | 
 **fiscalYear** | **decimal?**| Return financials for the given fiscal year | [optional] 

### Return type

[**ApiResponseMunicipalitiyFinancials**](ApiResponseMunicipalitiyFinancials.md)


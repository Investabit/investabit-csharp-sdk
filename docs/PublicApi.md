# IO.Swagger.Api.PublicApi

All URIs are relative to *https://api.investabit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PublicPriceChangeSymbolGet**](PublicApi.md#v1publicpricechangesymbolget) | **GET** /v1/public/price-change/{symbol} | Price Change
[**V1PublicPriceCurrentSymbolGet**](PublicApi.md#v1publicpricecurrentsymbolget) | **GET** /v1/public/price-current/{symbol} | Price Current
[**V1PublicPriceHistorySymbolPeriodIntervalGet**](PublicApi.md#v1publicpricehistorysymbolperiodintervalget) | **GET** /v1/public/price-history/{symbol}/{period}/{interval} | Price History
[**V1PublicSymbolsGet**](PublicApi.md#v1publicsymbolsget) | **GET** /v1/public/symbols | Symbols
[**V1PublicTrendSymbolGet**](PublicApi.md#v1publictrendsymbolget) | **GET** /v1/public/trend/{symbol} | Trend


<a name="v1publicpricechangesymbolget"></a>
# **V1PublicPriceChangeSymbolGet**
> PublicPriceChangeResponse V1PublicPriceChangeSymbolGet (string symbol)

Price Change

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicPriceChangeSymbolGetExample
    {
        public void main()
        {
            var apiInstance = new PublicApi();
            var symbol = btc;  // string | The cryptocurrency symbol.

            try
            {
                // Price Change
                PublicPriceChangeResponse result = apiInstance.V1PublicPriceChangeSymbolGet(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.V1PublicPriceChangeSymbolGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 

### Return type

[**PublicPriceChangeResponse**](PublicPriceChangeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1publicpricecurrentsymbolget"></a>
# **V1PublicPriceCurrentSymbolGet**
> PublicPriceCurrentResponse V1PublicPriceCurrentSymbolGet (string symbol)

Price Current

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicPriceCurrentSymbolGetExample
    {
        public void main()
        {
            var apiInstance = new PublicApi();
            var symbol = btc;  // string | The cryptocurrency symbol, provide `all` to get every symbol.

            try
            {
                // Price Current
                PublicPriceCurrentResponse result = apiInstance.V1PublicPriceCurrentSymbolGet(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.V1PublicPriceCurrentSymbolGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol, provide &#x60;all&#x60; to get every symbol. | 

### Return type

[**PublicPriceCurrentResponse**](PublicPriceCurrentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1publicpricehistorysymbolperiodintervalget"></a>
# **V1PublicPriceHistorySymbolPeriodIntervalGet**
> PublicPriceHistoryResponse V1PublicPriceHistorySymbolPeriodIntervalGet (string symbol, string period, string interval)

Price History

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicPriceHistorySymbolPeriodIntervalGetExample
    {
        public void main()
        {
            var apiInstance = new PublicApi();
            var symbol = btc;  // string | The cryptocurrency symbol, provide `all` to get every symbol.
            var period = 30d;  // string | The period to get data for, such as past 30 days.
            var interval = 1d;  // string | The bar interval, such as 1 day.

            try
            {
                // Price History
                PublicPriceHistoryResponse result = apiInstance.V1PublicPriceHistorySymbolPeriodIntervalGet(symbol, period, interval);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.V1PublicPriceHistorySymbolPeriodIntervalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol, provide &#x60;all&#x60; to get every symbol. | 
 **period** | **string**| The period to get data for, such as past 30 days. | 
 **interval** | **string**| The bar interval, such as 1 day. | 

### Return type

[**PublicPriceHistoryResponse**](PublicPriceHistoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1publicsymbolsget"></a>
# **V1PublicSymbolsGet**
> PublicSymbolsResponse V1PublicSymbolsGet ()

Symbols

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicSymbolsGetExample
    {
        public void main()
        {
            var apiInstance = new PublicApi();

            try
            {
                // Symbols
                PublicSymbolsResponse result = apiInstance.V1PublicSymbolsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.V1PublicSymbolsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PublicSymbolsResponse**](PublicSymbolsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1publictrendsymbolget"></a>
# **V1PublicTrendSymbolGet**
> PublicTrendResponse V1PublicTrendSymbolGet (string symbol)

Trend

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PublicTrendSymbolGetExample
    {
        public void main()
        {
            var apiInstance = new PublicApi();
            var symbol = btc;  // string | The cryptocurrency symbol.

            try
            {
                // Trend
                PublicTrendResponse result = apiInstance.V1PublicTrendSymbolGet(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicApi.V1PublicTrendSymbolGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 

### Return type

[**PublicTrendResponse**](PublicTrendResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.PrivateApi

All URIs are relative to *https://api.cryptoweather.ai*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PrivateAccuracySymbolIntervalPeriodGet**](PrivateApi.md#v1privateaccuracysymbolintervalperiodget) | **GET** /v1/private/accuracy/{symbol}/{interval}/{period} | Accuracy
[**V1PrivateForecastAccuracySymbolIntervalPeriodGet**](PrivateApi.md#v1privateforecastaccuracysymbolintervalperiodget) | **GET** /v1/private/forecast-accuracy/{symbol}/{interval}/{period} | Forecast Accuracy
[**V1PrivateForecastSymbolIntervalGet**](PrivateApi.md#v1privateforecastsymbolintervalget) | **GET** /v1/private/forecast/{symbol}/{interval} | Forecast
[**V1PrivateForecastTimeSymbolIntervalPeriodGet**](PrivateApi.md#v1privateforecasttimesymbolintervalperiodget) | **GET** /v1/private/forecast-time/{symbol}/{interval}/{period} | Forecast Time
[**V1PrivateTrendSymbolGet**](PrivateApi.md#v1privatetrendsymbolget) | **GET** /v1/private/trend/{symbol} | Trend
[**V1PrivateTrendTabularGet**](PrivateApi.md#v1privatetrendtabularget) | **GET** /v1/private/trend-tabular | Trend Tabular


<a name="v1privateaccuracysymbolintervalperiodget"></a>
# **V1PrivateAccuracySymbolIntervalPeriodGet**
> PrivateAccuracyResponse V1PrivateAccuracySymbolIntervalPeriodGet (string symbol, string interval, string period, string cookie = null, string xCsrf = null)

Accuracy

The accuracy response contains the following attributes.  + `rmse` Root Mean Square Error  + `mae` Mean Absolute error  + `r2` R Squared  + `ci` Confidence Interval lower and upper error bounds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PrivateAccuracySymbolIntervalPeriodGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrivateApi();
            var symbol = btc;  // string | The cryptocurrency symbol.
            var interval = 1h;  // string | The forecast interval, 1h or 1d.
            var period = 7d;  // string | The period for computing the accuracy, such as the past 7 days.
            var cookie = csrf=b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. csrf=b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 
            var xCsrf = b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 

            try
            {
                // Accuracy
                PrivateAccuracyResponse result = apiInstance.V1PrivateAccuracySymbolIntervalPeriodGet(symbol, interval, period, cookie, xCsrf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivateApi.V1PrivateAccuracySymbolIntervalPeriodGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 
 **interval** | **string**| The forecast interval, 1h or 1d. | 
 **period** | **string**| The period for computing the accuracy, such as the past 7 days. | 
 **cookie** | **string**| e.g. csrf&#x3D;b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 
 **xCsrf** | **string**| e.g. b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 

### Return type

[**PrivateAccuracyResponse**](PrivateAccuracyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1privateforecastaccuracysymbolintervalperiodget"></a>
# **V1PrivateForecastAccuracySymbolIntervalPeriodGet**
> PrivateForecastAccuracyResponse V1PrivateForecastAccuracySymbolIntervalPeriodGet (string symbol, string interval, string period, string cookie = null, string xCsrf = null)

Forecast Accuracy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PrivateForecastAccuracySymbolIntervalPeriodGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrivateApi();
            var symbol = btc;  // string | The cryptocurrency symbol.
            var interval = 1h;  // string | The forecast interval, 1h or 1d.
            var period = 7d;  // string | The period for computing the error bounds, typically 7d or 30d.
            var cookie = csrf=b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. csrf=b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 
            var xCsrf = b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 

            try
            {
                // Forecast Accuracy
                PrivateForecastAccuracyResponse result = apiInstance.V1PrivateForecastAccuracySymbolIntervalPeriodGet(symbol, interval, period, cookie, xCsrf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivateApi.V1PrivateForecastAccuracySymbolIntervalPeriodGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 
 **interval** | **string**| The forecast interval, 1h or 1d. | 
 **period** | **string**| The period for computing the error bounds, typically 7d or 30d. | 
 **cookie** | **string**| e.g. csrf&#x3D;b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 
 **xCsrf** | **string**| e.g. b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 

### Return type

[**PrivateForecastAccuracyResponse**](PrivateForecastAccuracyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1privateforecastsymbolintervalget"></a>
# **V1PrivateForecastSymbolIntervalGet**
> PrivateForecastResponse V1PrivateForecastSymbolIntervalGet (string symbol, string interval, string cookie = null, string xCsrf = null)

Forecast

The forecast response contains a sequence of forecasts at the specified intervals, with the following attributes.  + `time_start` start time of the period the forecast is applicable for  + `time_end` end time of the period the forecast is applicable for  + `low` forecasted high during the period  + `high` forecasted low during the period  + `weighted_price` forecasted weighted price during the period  + `change_pct` percent change in price for forecasted weighted_price relative to current price  + `change_usd` dollar change in price for forecasted weighted_price relative to current price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PrivateForecastSymbolIntervalGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrivateApi();
            var symbol = btc;  // string | The cryptocurrency symbol.
            var interval = 1h;  // string | The forecast interval, 1h or 1d.
            var cookie = csrf=b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. csrf=b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 
            var xCsrf = b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 

            try
            {
                // Forecast
                PrivateForecastResponse result = apiInstance.V1PrivateForecastSymbolIntervalGet(symbol, interval, cookie, xCsrf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivateApi.V1PrivateForecastSymbolIntervalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 
 **interval** | **string**| The forecast interval, 1h or 1d. | 
 **cookie** | **string**| e.g. csrf&#x3D;b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 
 **xCsrf** | **string**| e.g. b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 

### Return type

[**PrivateForecastResponse**](PrivateForecastResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1privateforecasttimesymbolintervalperiodget"></a>
# **V1PrivateForecastTimeSymbolIntervalPeriodGet**
> PrivateForecastTimeResponse V1PrivateForecastTimeSymbolIntervalPeriodGet (string symbol, string interval, string period, string cookie = null, string xCsrf = null)

Forecast Time

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PrivateForecastTimeSymbolIntervalPeriodGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrivateApi();
            var symbol = btc;  // string | The cryptocurrency symbol.
            var interval = 1h;  // string | The forecast interval, 1h or 1d.
            var period = 7d;  // string | The period for computing the error bounds, typically 7d or 30d.
            var cookie = csrf=b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. csrf=b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 
            var xCsrf = b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 

            try
            {
                // Forecast Time
                PrivateForecastTimeResponse result = apiInstance.V1PrivateForecastTimeSymbolIntervalPeriodGet(symbol, interval, period, cookie, xCsrf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivateApi.V1PrivateForecastTimeSymbolIntervalPeriodGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 
 **interval** | **string**| The forecast interval, 1h or 1d. | 
 **period** | **string**| The period for computing the error bounds, typically 7d or 30d. | 
 **cookie** | **string**| e.g. csrf&#x3D;b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 
 **xCsrf** | **string**| e.g. b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 

### Return type

[**PrivateForecastTimeResponse**](PrivateForecastTimeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1privatetrendsymbolget"></a>
# **V1PrivateTrendSymbolGet**
> PublicTrendResponse V1PrivateTrendSymbolGet (string symbol, string cookie = null, string xCsrf = null)

Trend

The trend response contains a collection of forecasts for different intervals with the following attributes.  + `time_start` start time of the period the forecast is applicable for  + `time_end` end time of the period the forecast is applicable for  + `interval` interval in hours that the forecast is applicable for  + `weighted_price` forecasted weighted price during the period  + `change_pct` percent change in price for forecasted weighted_price relative to current price  + `change_usd` dollar change in price for forecasted weighted_price relative to current price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PrivateTrendSymbolGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrivateApi();
            var symbol = btc;  // string | The cryptocurrency symbol.
            var cookie = csrf=b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. csrf=b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 
            var xCsrf = b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 

            try
            {
                // Trend
                PublicTrendResponse result = apiInstance.V1PrivateTrendSymbolGet(symbol, cookie, xCsrf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivateApi.V1PrivateTrendSymbolGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The cryptocurrency symbol. | 
 **cookie** | **string**| e.g. csrf&#x3D;b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 
 **xCsrf** | **string**| e.g. b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 

### Return type

[**PublicTrendResponse**](PublicTrendResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1privatetrendtabularget"></a>
# **V1PrivateTrendTabularGet**
> PrivateTrendTabularResponse V1PrivateTrendTabularGet (string cookie = null, string xCsrf = null)

Trend Tabular

The trend tabular response contains a collection of forecasts for all supported cryptocurrencies at different intervals with the following attributes.  + `time_start` start time of the period the forecast is applicable for  + `time_end` end time of the period the forecast is applicable for  + `interval` interval in hours that the forecast is applicable for  + `weighted_price` forecasted weighted price during the period  + `change_pct` percent change in price for forecasted weighted_price relative to current price  + `change_usd` dollar change in price for forecasted weighted_price relative to current price

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1PrivateTrendTabularGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PrivateApi();
            var cookie = csrf=b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. csrf=b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 
            var xCsrf = b1820141-1bad-4a9c-93c0-52022817ce89;  // string | e.g. b1820141-1bad-4a9c-93c0-52022817ce89 (optional) 

            try
            {
                // Trend Tabular
                PrivateTrendTabularResponse result = apiInstance.V1PrivateTrendTabularGet(cookie, xCsrf);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivateApi.V1PrivateTrendTabularGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cookie** | **string**| e.g. csrf&#x3D;b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 
 **xCsrf** | **string**| e.g. b1820141-1bad-4a9c-93c0-52022817ce89 | [optional] 

### Return type

[**PrivateTrendTabularResponse**](PrivateTrendTabularResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger - the C# library for the Investabit

The Investabit API allows for access to all of the public facing services provided, including market data and forecasts.  ## General Overview  1. All API methods will be built to adhere to RESTful best practices as closely as possible. As such, all API calls will be made via the standard HTTP protocol using the GET/POST/PUT/DELETE request types.  2. Every request returns the status as a JSON response with the following   - success, true if it was successful   - code, the http status code (also in the response header)          200 if response is successful          400 if bad request          401 if authorization JWT is wrong or limit exceeded          404 wrong route          500 for any internal errors  - status, the status of the request, default **success**  - errors, an array of any relevant error details  3. For any requests that are not successful an error message is specified and returned as an array for the **errors** key in the JSON response.  4. All authentication uses JSON Web Tokens (JWT), which is set as the **Authorization** entry in the header, see the following for more details.     * http://jwt.io     * https://scotch.io/tutorials/the-anatomy-of-a-json-web-token

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.investabit.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PublicApi* | [**V1PublicPriceChangeSymbolGet**](docs/PublicApi.md#v1publicpricechangesymbolget) | **GET** /v1/public/price-change/{symbol} | Price Change
*PublicApi* | [**V1PublicPriceCurrentSymbolGet**](docs/PublicApi.md#v1publicpricecurrentsymbolget) | **GET** /v1/public/price-current/{symbol} | Price Current
*PublicApi* | [**V1PublicPriceHistorySymbolPeriodIntervalGet**](docs/PublicApi.md#v1publicpricehistorysymbolperiodintervalget) | **GET** /v1/public/price-history/{symbol}/{period}/{interval} | Price History
*PublicApi* | [**V1PublicSymbolsGet**](docs/PublicApi.md#v1publicsymbolsget) | **GET** /v1/public/symbols | Symbols
*PublicApi* | [**V1PublicTrendSymbolGet**](docs/PublicApi.md#v1publictrendsymbolget) | **GET** /v1/public/trend/{symbol} | Trend


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.DefaultResponse](docs/DefaultResponse.md)
 - [Model.PriceChangeRoute](docs/PriceChangeRoute.md)
 - [Model.PriceCurrentRoute](docs/PriceCurrentRoute.md)
 - [Model.PriceHistoryRoute](docs/PriceHistoryRoute.md)
 - [Model.PublicPriceChangeResponse](docs/PublicPriceChangeResponse.md)
 - [Model.PublicPriceChangeResponseData](docs/PublicPriceChangeResponseData.md)
 - [Model.PublicPriceChangeResponseDataPriceChange](docs/PublicPriceChangeResponseDataPriceChange.md)
 - [Model.PublicPriceCurrentResponse](docs/PublicPriceCurrentResponse.md)
 - [Model.PublicPriceCurrentResponseData](docs/PublicPriceCurrentResponseData.md)
 - [Model.PublicPriceCurrentResponseDataCurrent](docs/PublicPriceCurrentResponseDataCurrent.md)
 - [Model.PublicPriceHistoryResponse](docs/PublicPriceHistoryResponse.md)
 - [Model.PublicPriceHistoryResponseData](docs/PublicPriceHistoryResponseData.md)
 - [Model.PublicPriceHistoryResponseDataHistory](docs/PublicPriceHistoryResponseDataHistory.md)
 - [Model.PublicPriceHistoryResponseDataPriceHistory](docs/PublicPriceHistoryResponseDataPriceHistory.md)
 - [Model.PublicSymbolsResponse](docs/PublicSymbolsResponse.md)
 - [Model.PublicSymbolsResponseData](docs/PublicSymbolsResponseData.md)
 - [Model.PublicSymbolsResponseDataSymbols](docs/PublicSymbolsResponseDataSymbols.md)
 - [Model.PublicTrendResponse](docs/PublicTrendResponse.md)
 - [Model.PublicTrendResponseData](docs/PublicTrendResponseData.md)
 - [Model.PublicTrendResponseDataTrend](docs/PublicTrendResponseDataTrend.md)
 - [Model.SymbolsRoute](docs/SymbolsRoute.md)
 - [Model.TrendRoute](docs/TrendRoute.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.

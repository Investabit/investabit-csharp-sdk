/* 
 * CryptoWeather
 *
 * The CryptoWeather API allows for access to all of the cryptocurrency data and market forecast services provided. There are two primary categories of routes, `public` and `private`, where `public` routes are accessible to the general public and do not require API authentication, and `private` routes, which require API authentication.  ## General Overview  1. All API methods adhere to RESTful best practices as closely as possible. As such, all API calls will be made via the standard HTTP protocol using the GET/POST/PUT/DELETE request types.  2. Every request returns the status as a JSON response with the following:     - success, true if it was successful     - code, the http status code (also in the response header)         - 200 if response is successful         - 400 if bad request         - 401 if authorization JWT is wrong or limit exceeded         - 404 wrong route         - 500 for any internal errors     - status, the status of the request, default **success**     - errors, an array of any relevant error details  3. For any requests that are not successful an error message is specified and returned as an array for the **errors** key in the JSON response.  4. All authentication uses JSON Web Tokens (JWT), which is set as the **Authorization** entry in the header, see the following for more details.     - http://jwt.io     - https://scotch.io/tutorials/the-anatomy-of-a-json-web-token  ## Code Example  The following is a code example in Python, which demonstrates using the [Python Requests library](https://requests.readthedocs.io/en/master/) for both the `public` and `private` API routes.  ``` import requests  HOST = \"https://api.cryptoweather.ai/v1\"  # Your API key (JWT) API_KEY = \"<YOUR API KEY>\"  # Example public request, no API key required. requests.get(\"{}/public/symbols\".format(HOST)).json()  # Get the current btc price using the public route requests.get(\"{}/public/price-current/{}\".format(HOST, \"btc\")).json()   # Example private request, API key required. Get the btc hourly forecasts headers = {\"Authorization\": \"Bearer {}\".format(API_KEY)} requests.get(\"{}/private/forecast/{}/{}\".format(HOST, \"btc\", \"1h\"),              headers=headers).json() ```
 *
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PublicApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicApiTests
    {
        private PublicApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicApi
            //Assert.IsInstanceOfType(typeof(PublicApi), instance, "instance is a PublicApi");
        }

        
        /// <summary>
        /// Test V1PublicPriceChangeSymbolGet
        /// </summary>
        [Test]
        public void V1PublicPriceChangeSymbolGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.V1PublicPriceChangeSymbolGet(symbol);
            //Assert.IsInstanceOf<PublicPriceChangeResponse> (response, "response is PublicPriceChangeResponse");
        }
        
        /// <summary>
        /// Test V1PublicPriceCurrentSymbolGet
        /// </summary>
        [Test]
        public void V1PublicPriceCurrentSymbolGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.V1PublicPriceCurrentSymbolGet(symbol);
            //Assert.IsInstanceOf<PublicPriceCurrentResponse> (response, "response is PublicPriceCurrentResponse");
        }
        
        /// <summary>
        /// Test V1PublicPriceHistorySymbolPeriodIntervalGet
        /// </summary>
        [Test]
        public void V1PublicPriceHistorySymbolPeriodIntervalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string period = null;
            //string interval = null;
            //var response = instance.V1PublicPriceHistorySymbolPeriodIntervalGet(symbol, period, interval);
            //Assert.IsInstanceOf<PublicPriceHistoryResponse> (response, "response is PublicPriceHistoryResponse");
        }
        
        /// <summary>
        /// Test V1PublicSummaryGet
        /// </summary>
        [Test]
        public void V1PublicSummaryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1PublicSummaryGet();
            //Assert.IsInstanceOf<PublicSummaryResponse> (response, "response is PublicSummaryResponse");
        }
        
        /// <summary>
        /// Test V1PublicSymbolsGet
        /// </summary>
        [Test]
        public void V1PublicSymbolsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1PublicSymbolsGet();
            //Assert.IsInstanceOf<PublicSymbolsResponse> (response, "response is PublicSymbolsResponse");
        }
        
        /// <summary>
        /// Test V1PublicTrendSymbolGet
        /// </summary>
        [Test]
        public void V1PublicTrendSymbolGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.V1PublicTrendSymbolGet(symbol);
            //Assert.IsInstanceOf<PublicTrendResponse> (response, "response is PublicTrendResponse");
        }
        
    }

}

/* 
 * CryptoWeather
 *
 * The CryptoWeather API allows for access to all of the cryptocurrency data and market forecast services provided. There are two primary categories of routes, `public` and `private`, where `public` routes are accessible to the general public and do not require API authentication, and `private` routes, which require API authentication.  ## General Overview  1. All API methods adhere to RESTful best practices as closely as possible. As such, all API calls will be made via the standard HTTP protocol using the GET/POST/PUT/DELETE request types.  2. Every request returns the status as a JSON response with the following:     - success, true if it was successful     - code, the http status code (also in the response header)         - 200 if response is successful         - 400 if bad request         - 401 if authorization JWT is wrong or limit exceeded         - 404 wrong route         - 500 for any internal errors     - status, the status of the request, default **success**     - errors, an array of any relevant error details  3. For any requests that are not successful an error message is specified and returned as an array for the **errors** key in the JSON response.  4. All authentication uses JSON Web Tokens (JWT), which is set as the **Authorization** entry in the header, see the following for more details.     - http://jwt.io     - https://scotch.io/tutorials/the-anatomy-of-a-json-web-token  ## Code Example  The following is a code example in Python, which demonstrates using the [Python Requests library](https://requests.readthedocs.io/en/master/) for both the `public` and `private` API routes.  ``` import requests  HOST = \"https://api.cryptoweather.ai/v1\"  # Your API key (JWT) API_KEY = \"<YOUR API KEY>\"  # Example public request, no API key required. requests.get(\"{}/public/symbols\".format(HOST)).json()  # Get the current btc price using the public route requests.get(\"{}/public/price-current/{}\".format(HOST, \"btc\")).json()   # Example private request, API key required. Get the btc hourly forecasts headers = {\"Authorization\": \"Bearer {}\".format(API_KEY)} requests.get(\"{}/private/forecast/{}/{}\".format(HOST, \"btc\", \"1h\"),              headers=headers).json() ```
 *
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PublicTrendResponseDataTrend
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PublicTrendResponseDataTrendTests
    {
        // TODO uncomment below to declare an instance variable for PublicTrendResponseDataTrend
        //private PublicTrendResponseDataTrend instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PublicTrendResponseDataTrend
            //instance = new PublicTrendResponseDataTrend();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicTrendResponseDataTrend
        /// </summary>
        [Test]
        public void PublicTrendResponseDataTrendInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PublicTrendResponseDataTrend
            //Assert.IsInstanceOfType<PublicTrendResponseDataTrend> (instance, "variable 'instance' is a PublicTrendResponseDataTrend");
        }


        /// <summary>
        /// Test the property 'TimeStart'
        /// </summary>
        [Test]
        public void TimeStartTest()
        {
            // TODO unit test for the property 'TimeStart'
        }
        /// <summary>
        /// Test the property 'TimeEnd'
        /// </summary>
        [Test]
        public void TimeEndTest()
        {
            // TODO unit test for the property 'TimeEnd'
        }
        /// <summary>
        /// Test the property 'Interval'
        /// </summary>
        [Test]
        public void IntervalTest()
        {
            // TODO unit test for the property 'Interval'
        }
        /// <summary>
        /// Test the property 'WeightedPrice'
        /// </summary>
        [Test]
        public void WeightedPriceTest()
        {
            // TODO unit test for the property 'WeightedPrice'
        }
        /// <summary>
        /// Test the property 'ChangeUsd'
        /// </summary>
        [Test]
        public void ChangeUsdTest()
        {
            // TODO unit test for the property 'ChangeUsd'
        }
        /// <summary>
        /// Test the property 'ChangePct'
        /// </summary>
        [Test]
        public void ChangePctTest()
        {
            // TODO unit test for the property 'ChangePct'
        }
        /// <summary>
        /// Test the property 'Confidence'
        /// </summary>
        [Test]
        public void ConfidenceTest()
        {
            // TODO unit test for the property 'Confidence'
        }

    }

}

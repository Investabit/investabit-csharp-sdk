/* 
 * Investabit
 *
 * The Investabit API allows for access to all of the public facing services provided, including market data and forecasts.  ## General Overview  1. All API methods will be built to adhere to RESTful best practices as closely as possible. As such, all API calls will be made via the standard HTTP protocol using the GET/POST/PUT/DELETE request types.  2. Every request returns the status as a JSON response with the following   - success, true if it was successful   - code, the http status code (also in the response header)          200 if response is successful          400 if bad request          401 if authorization JWT is wrong or limit exceeded          404 wrong route          500 for any internal errors  - status, the status of the request, default **success**  - errors, an array of any relevant error details  3. For any requests that are not successful an error message is specified and returned as an array for the **errors** key in the JSON response.  4. All authentication uses JSON Web Tokens (JWT), which is set as the **Authorization** entry in the header, see the following for more details.     * http://jwt.io     * https://scotch.io/tutorials/the-anatomy-of-a-json-web-token
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
    ///  Class for testing PublicPriceChangeResponseData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PublicPriceChangeResponseDataTests
    {
        // TODO uncomment below to declare an instance variable for PublicPriceChangeResponseData
        //private PublicPriceChangeResponseData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PublicPriceChangeResponseData
            //instance = new PublicPriceChangeResponseData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicPriceChangeResponseData
        /// </summary>
        [Test]
        public void PublicPriceChangeResponseDataInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PublicPriceChangeResponseData
            //Assert.IsInstanceOfType<PublicPriceChangeResponseData> (instance, "variable 'instance' is a PublicPriceChangeResponseData");
        }


        /// <summary>
        /// Test the property 'PriceChange'
        /// </summary>
        [Test]
        public void PriceChangeTest()
        {
            // TODO unit test for the property 'PriceChange'
        }

    }

}

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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PublicPriceHistoryResponseData
    /// </summary>
    [DataContract]
    public partial class PublicPriceHistoryResponseData :  IEquatable<PublicPriceHistoryResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPriceHistoryResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicPriceHistoryResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPriceHistoryResponseData" /> class.
        /// </summary>
        /// <param name="priceHistory">priceHistory (required).</param>
        public PublicPriceHistoryResponseData(List<PublicPriceHistoryResponseDataPriceHistory> priceHistory = default(List<PublicPriceHistoryResponseDataPriceHistory>))
        {
            // to ensure "priceHistory" is required (not null)
            if (priceHistory == null)
            {
                throw new InvalidDataException("priceHistory is a required property for PublicPriceHistoryResponseData and cannot be null");
            }
            else
            {
                this.PriceHistory = priceHistory;
            }
        }
        
        /// <summary>
        /// Gets or Sets PriceHistory
        /// </summary>
        [DataMember(Name="price_history", EmitDefaultValue=false)]
        public List<PublicPriceHistoryResponseDataPriceHistory> PriceHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicPriceHistoryResponseData {\n");
            sb.Append("  PriceHistory: ").Append(PriceHistory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicPriceHistoryResponseData);
        }

        /// <summary>
        /// Returns true if PublicPriceHistoryResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicPriceHistoryResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicPriceHistoryResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriceHistory == input.PriceHistory ||
                    this.PriceHistory != null &&
                    this.PriceHistory.SequenceEqual(input.PriceHistory)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PriceHistory != null)
                    hashCode = hashCode * 59 + this.PriceHistory.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

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
    /// PublicSummaryResponseData
    /// </summary>
    [DataContract]
    public partial class PublicSummaryResponseData :  IEquatable<PublicSummaryResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSummaryResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicSummaryResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSummaryResponseData" /> class.
        /// </summary>
        /// <param name="icon">icon (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="symbolName">symbolName (required).</param>
        /// <param name="slug">slug (required).</param>
        /// <param name="added">added (required).</param>
        /// <param name="color">color (required).</param>
        /// <param name="priceBtc">priceBtc (required).</param>
        /// <param name="priceUsd">priceUsd (required).</param>
        /// <param name="marketCap">marketCap (required).</param>
        /// <param name="volumeUsd">volumeUsd (required).</param>
        /// <param name="changePct">changePct (required).</param>
        /// <param name="marketDataTime">marketDataTime (required).</param>
        /// <param name="trend">trend (required).</param>
        public PublicSummaryResponseData(string icon = default(string), string name = default(string), string symbolName = default(string), string slug = default(string), decimal? added = default(decimal?), PublicSummaryResponseColor color = default(PublicSummaryResponseColor), decimal? priceBtc = default(decimal?), decimal? priceUsd = default(decimal?), decimal? marketCap = default(decimal?), decimal? volumeUsd = default(decimal?), decimal? changePct = default(decimal?), decimal? marketDataTime = default(decimal?), List<PublicTrendResponseDataTrend> trend = default(List<PublicTrendResponseDataTrend>))
        {
            // to ensure "icon" is required (not null)
            if (icon == null)
            {
                throw new InvalidDataException("icon is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.Icon = icon;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "symbolName" is required (not null)
            if (symbolName == null)
            {
                throw new InvalidDataException("symbolName is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.SymbolName = symbolName;
            }
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            // to ensure "added" is required (not null)
            if (added == null)
            {
                throw new InvalidDataException("added is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.Added = added;
            }
            // to ensure "color" is required (not null)
            if (color == null)
            {
                throw new InvalidDataException("color is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.Color = color;
            }
            // to ensure "priceBtc" is required (not null)
            if (priceBtc == null)
            {
                throw new InvalidDataException("priceBtc is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.PriceBtc = priceBtc;
            }
            // to ensure "priceUsd" is required (not null)
            if (priceUsd == null)
            {
                throw new InvalidDataException("priceUsd is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.PriceUsd = priceUsd;
            }
            // to ensure "marketCap" is required (not null)
            if (marketCap == null)
            {
                throw new InvalidDataException("marketCap is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.MarketCap = marketCap;
            }
            // to ensure "volumeUsd" is required (not null)
            if (volumeUsd == null)
            {
                throw new InvalidDataException("volumeUsd is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.VolumeUsd = volumeUsd;
            }
            // to ensure "changePct" is required (not null)
            if (changePct == null)
            {
                throw new InvalidDataException("changePct is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.ChangePct = changePct;
            }
            // to ensure "marketDataTime" is required (not null)
            if (marketDataTime == null)
            {
                throw new InvalidDataException("marketDataTime is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.MarketDataTime = marketDataTime;
            }
            // to ensure "trend" is required (not null)
            if (trend == null)
            {
                throw new InvalidDataException("trend is a required property for PublicSummaryResponseData and cannot be null");
            }
            else
            {
                this.Trend = trend;
            }
        }
        
        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SymbolName
        /// </summary>
        [DataMember(Name="symbol_name", EmitDefaultValue=false)]
        public string SymbolName { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public decimal? Added { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public PublicSummaryResponseColor Color { get; set; }

        /// <summary>
        /// Gets or Sets PriceBtc
        /// </summary>
        [DataMember(Name="price_btc", EmitDefaultValue=false)]
        public decimal? PriceBtc { get; set; }

        /// <summary>
        /// Gets or Sets PriceUsd
        /// </summary>
        [DataMember(Name="price_usd", EmitDefaultValue=false)]
        public decimal? PriceUsd { get; set; }

        /// <summary>
        /// Gets or Sets MarketCap
        /// </summary>
        [DataMember(Name="market_cap", EmitDefaultValue=false)]
        public decimal? MarketCap { get; set; }

        /// <summary>
        /// Gets or Sets VolumeUsd
        /// </summary>
        [DataMember(Name="volume_usd", EmitDefaultValue=false)]
        public decimal? VolumeUsd { get; set; }

        /// <summary>
        /// Gets or Sets ChangePct
        /// </summary>
        [DataMember(Name="change_pct", EmitDefaultValue=false)]
        public decimal? ChangePct { get; set; }

        /// <summary>
        /// Gets or Sets MarketDataTime
        /// </summary>
        [DataMember(Name="market_data_time", EmitDefaultValue=false)]
        public decimal? MarketDataTime { get; set; }

        /// <summary>
        /// Gets or Sets Trend
        /// </summary>
        [DataMember(Name="trend", EmitDefaultValue=false)]
        public List<PublicTrendResponseDataTrend> Trend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicSummaryResponseData {\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SymbolName: ").Append(SymbolName).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  PriceBtc: ").Append(PriceBtc).Append("\n");
            sb.Append("  PriceUsd: ").Append(PriceUsd).Append("\n");
            sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
            sb.Append("  VolumeUsd: ").Append(VolumeUsd).Append("\n");
            sb.Append("  ChangePct: ").Append(ChangePct).Append("\n");
            sb.Append("  MarketDataTime: ").Append(MarketDataTime).Append("\n");
            sb.Append("  Trend: ").Append(Trend).Append("\n");
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
            return this.Equals(input as PublicSummaryResponseData);
        }

        /// <summary>
        /// Returns true if PublicSummaryResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicSummaryResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicSummaryResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SymbolName == input.SymbolName ||
                    (this.SymbolName != null &&
                    this.SymbolName.Equals(input.SymbolName))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.PriceBtc == input.PriceBtc ||
                    (this.PriceBtc != null &&
                    this.PriceBtc.Equals(input.PriceBtc))
                ) && 
                (
                    this.PriceUsd == input.PriceUsd ||
                    (this.PriceUsd != null &&
                    this.PriceUsd.Equals(input.PriceUsd))
                ) && 
                (
                    this.MarketCap == input.MarketCap ||
                    (this.MarketCap != null &&
                    this.MarketCap.Equals(input.MarketCap))
                ) && 
                (
                    this.VolumeUsd == input.VolumeUsd ||
                    (this.VolumeUsd != null &&
                    this.VolumeUsd.Equals(input.VolumeUsd))
                ) && 
                (
                    this.ChangePct == input.ChangePct ||
                    (this.ChangePct != null &&
                    this.ChangePct.Equals(input.ChangePct))
                ) && 
                (
                    this.MarketDataTime == input.MarketDataTime ||
                    (this.MarketDataTime != null &&
                    this.MarketDataTime.Equals(input.MarketDataTime))
                ) && 
                (
                    this.Trend == input.Trend ||
                    this.Trend != null &&
                    this.Trend.SequenceEqual(input.Trend)
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
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SymbolName != null)
                    hashCode = hashCode * 59 + this.SymbolName.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.PriceBtc != null)
                    hashCode = hashCode * 59 + this.PriceBtc.GetHashCode();
                if (this.PriceUsd != null)
                    hashCode = hashCode * 59 + this.PriceUsd.GetHashCode();
                if (this.MarketCap != null)
                    hashCode = hashCode * 59 + this.MarketCap.GetHashCode();
                if (this.VolumeUsd != null)
                    hashCode = hashCode * 59 + this.VolumeUsd.GetHashCode();
                if (this.ChangePct != null)
                    hashCode = hashCode * 59 + this.ChangePct.GetHashCode();
                if (this.MarketDataTime != null)
                    hashCode = hashCode * 59 + this.MarketDataTime.GetHashCode();
                if (this.Trend != null)
                    hashCode = hashCode * 59 + this.Trend.GetHashCode();
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
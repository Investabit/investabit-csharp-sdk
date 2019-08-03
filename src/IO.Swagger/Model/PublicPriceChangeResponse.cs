/* 
 * Investabit
 *
 * The Investabit API allows for access to all of the public facing services provided, including market data and forecasts.  ## General Overview  1. All API methods will be built to adhere to RESTful best practices as closely as possible. As such, all API calls will be made via the standard HTTP protocol using the GET/POST/PUT/DELETE request types.  2. Every request returns the status as a JSON response with the following   - success, true if it was successful   - code, the http status code (also in the response header)          200 if response is successful          400 if bad request          401 if authorization JWT is wrong or limit exceeded          404 wrong route          500 for any internal errors  - status, the status of the request, default **success**  - errors, an array of any relevant error details  3. For any requests that are not successful an error message is specified and returned as an array for the **errors** key in the JSON response.  4. All authentication uses JSON Web Tokens (JWT), which is set as the **Authorization** entry in the header, see the following for more details.     * http://jwt.io     * https://scotch.io/tutorials/the-anatomy-of-a-json-web-token
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
    /// PublicPriceChangeResponse
    /// </summary>
    [DataContract]
    public partial class PublicPriceChangeResponse :  IEquatable<PublicPriceChangeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPriceChangeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicPriceChangeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPriceChangeResponse" /> class.
        /// </summary>
        /// <param name="success">success (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="errors">errors.</param>
        public PublicPriceChangeResponse(bool? success = default(bool?), int? code = default(int?), string status = default(string), PublicPriceChangeResponseData data = default(PublicPriceChangeResponseData), List<Object> errors = default(List<Object>))
        {
            // to ensure "success" is required (not null)
            if (success == null)
            {
                throw new InvalidDataException("success is a required property for PublicPriceChangeResponse and cannot be null");
            }
            else
            {
                this.Success = success;
            }
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for PublicPriceChangeResponse and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for PublicPriceChangeResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for PublicPriceChangeResponse and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            this.Errors = errors;
        }
        
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public PublicPriceChangeResponseData Data { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Object> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicPriceChangeResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as PublicPriceChangeResponse);
        }

        /// <summary>
        /// Returns true if PublicPriceChangeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicPriceChangeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicPriceChangeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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

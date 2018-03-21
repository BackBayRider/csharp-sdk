/* 
 * Intrinio API
 *
 * Welcome to the Intrinio API! Through our Marketplace, we offer a wide selection of financial data feeds sourced by our own proprietary processes as well as from many data vendors. The primary application of the Intrinio API is for use in third-party applications and integrations or for end-users utilizing the Excel add-in and Google Sheets add-on. The Intrinio API uses HTTPS verbs and a RESTful endpoint structure, which makes it easy to request data from Intrinio. Responses are delivered in JSON format. If you need additional help in using the API, go to our home page (https://intrinio.com) and click on the chat icon in the lower right corner.
 *
 * OpenAPI spec version: 2.0.0
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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// Fundamental
    /// </summary>
    [DataContract]
    public partial class Fundamental :  IEquatable<Fundamental>, IValidatableObject
    {
        /// <summary>
        /// The type of Fundamental
        /// </summary>
        /// <value>The type of Fundamental</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Reported for value: "reported"
            /// </summary>
            [EnumMember(Value = "reported")]
            Reported = 1,
            
            /// <summary>
            /// Enum Restated for value: "restated"
            /// </summary>
            [EnumMember(Value = "restated")]
            Restated = 2,
            
            /// <summary>
            /// Enum Calculated for value: "calculated"
            /// </summary>
            [EnumMember(Value = "calculated")]
            Calculated = 3
        }

        /// <summary>
        /// The type of Fundamental
        /// </summary>
        /// <value>The type of Fundamental</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Fundamental" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the Fundamental.</param>
        /// <param name="Company">The Company that the Fundamental was belongs to.</param>
        /// <param name="StatementCode">The code of the financial statement that the Fundamental represents.</param>
        /// <param name="FiscalYear">The fiscal year.</param>
        /// <param name="FiscalPeriod">The fiscal period.</param>
        /// <param name="Type">The type of Fundamental.</param>
        /// <param name="StartDate">The period start date.</param>
        /// <param name="EndDate">The period start date.</param>
        /// <param name="FilingDate">The date and time when the Fundamental was filed with the SEC.</param>
        /// <param name="Calculated">If true, this Fundamental was calculated by Intrinio and not actually reported by the Company.</param>
        public Fundamental(string Id = default(string), CompanySummary Company = default(CompanySummary), string StatementCode = default(string), decimal? FiscalYear = default(decimal?), string FiscalPeriod = default(string), TypeEnum? Type = default(TypeEnum?), DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?), DateTime? FilingDate = default(DateTime?), bool? Calculated = default(bool?))
        {
            this.Id = Id;
            this.Company = Company;
            this.StatementCode = StatementCode;
            this.FiscalYear = FiscalYear;
            this.FiscalPeriod = FiscalPeriod;
            this.Type = Type;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.FilingDate = FilingDate;
            this.Calculated = Calculated;
        }
        
        /// <summary>
        /// The Intrinio ID of the Fundamental
        /// </summary>
        /// <value>The Intrinio ID of the Fundamental</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The Company that the Fundamental was belongs to
        /// </summary>
        /// <value>The Company that the Fundamental was belongs to</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// The code of the financial statement that the Fundamental represents
        /// </summary>
        /// <value>The code of the financial statement that the Fundamental represents</value>
        [DataMember(Name="statement_code", EmitDefaultValue=false)]
        public string StatementCode { get; set; }

        /// <summary>
        /// The fiscal year
        /// </summary>
        /// <value>The fiscal year</value>
        [DataMember(Name="fiscal_year", EmitDefaultValue=false)]
        public decimal? FiscalYear { get; set; }

        /// <summary>
        /// The fiscal period
        /// </summary>
        /// <value>The fiscal period</value>
        [DataMember(Name="fiscal_period", EmitDefaultValue=false)]
        public string FiscalPeriod { get; set; }


        /// <summary>
        /// The period start date
        /// </summary>
        /// <value>The period start date</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The period start date
        /// </summary>
        /// <value>The period start date</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The date and time when the Fundamental was filed with the SEC
        /// </summary>
        /// <value>The date and time when the Fundamental was filed with the SEC</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FilingDate { get; set; }

        /// <summary>
        /// If true, this Fundamental was calculated by Intrinio and not actually reported by the Company
        /// </summary>
        /// <value>If true, this Fundamental was calculated by Intrinio and not actually reported by the Company</value>
        [DataMember(Name="calculated", EmitDefaultValue=false)]
        public bool? Calculated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fundamental {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  StatementCode: ").Append(StatementCode).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  FiscalPeriod: ").Append(FiscalPeriod).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
            sb.Append("  Calculated: ").Append(Calculated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Fundamental);
        }

        /// <summary>
        /// Returns true if Fundamental instances are equal
        /// </summary>
        /// <param name="input">Instance of Fundamental to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fundamental input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.StatementCode == input.StatementCode ||
                    (this.StatementCode != null &&
                    this.StatementCode.Equals(input.StatementCode))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    (this.FiscalYear != null &&
                    this.FiscalYear.Equals(input.FiscalYear))
                ) && 
                (
                    this.FiscalPeriod == input.FiscalPeriod ||
                    (this.FiscalPeriod != null &&
                    this.FiscalPeriod.Equals(input.FiscalPeriod))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
                ) && 
                (
                    this.Calculated == input.Calculated ||
                    (this.Calculated != null &&
                    this.Calculated.Equals(input.Calculated))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.StatementCode != null)
                    hashCode = hashCode * 59 + this.StatementCode.GetHashCode();
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.FiscalPeriod != null)
                    hashCode = hashCode * 59 + this.FiscalPeriod.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
                if (this.Calculated != null)
                    hashCode = hashCode * 59 + this.Calculated.GetHashCode();
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
/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: devrel@onesignal.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OneSignalApi.Client.OpenAPIDateConverter;

namespace OneSignalApi.Model
{
    /// <summary>
    /// PlatformDeliveryDataSmsAllOf
    /// </summary>
    [DataContract(Name = "PlatformDeliveryData_sms_allOf")]
    public partial class PlatformDeliveryDataSmsAllOf : IEquatable<PlatformDeliveryDataSmsAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformDeliveryDataSmsAllOf" /> class.
        /// </summary>
        /// <param name="providerSuccessful">Number of messages reported as delivered successfully by the SMS service provider..</param>
        /// <param name="providerFailed">Number of recipients who didn&#39;t receive your message as reported by the SMS service provider..</param>
        /// <param name="providerErrored">Number of errors reported by the SMS service provider..</param>
        public PlatformDeliveryDataSmsAllOf(int? providerSuccessful = default(int?), int? providerFailed = default(int?), int? providerErrored = default(int?))
        {
            this.ProviderSuccessful = providerSuccessful;
            this.ProviderFailed = providerFailed;
            this.ProviderErrored = providerErrored;
        }

        /// <summary>
        /// Number of messages reported as delivered successfully by the SMS service provider.
        /// </summary>
        /// <value>Number of messages reported as delivered successfully by the SMS service provider.</value>
        [DataMember(Name = "provider_successful", EmitDefaultValue = true)]
        public int? ProviderSuccessful { get; set; }

        /// <summary>
        /// Number of recipients who didn&#39;t receive your message as reported by the SMS service provider.
        /// </summary>
        /// <value>Number of recipients who didn&#39;t receive your message as reported by the SMS service provider.</value>
        [DataMember(Name = "provider_failed", EmitDefaultValue = true)]
        public int? ProviderFailed { get; set; }

        /// <summary>
        /// Number of errors reported by the SMS service provider.
        /// </summary>
        /// <value>Number of errors reported by the SMS service provider.</value>
        [DataMember(Name = "provider_errored", EmitDefaultValue = true)]
        public int? ProviderErrored { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlatformDeliveryDataSmsAllOf {\n");
            sb.Append("  ProviderSuccessful: ").Append(ProviderSuccessful).Append("\n");
            sb.Append("  ProviderFailed: ").Append(ProviderFailed).Append("\n");
            sb.Append("  ProviderErrored: ").Append(ProviderErrored).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformDeliveryDataSmsAllOf);
        }

        /// <summary>
        /// Returns true if PlatformDeliveryDataSmsAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PlatformDeliveryDataSmsAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlatformDeliveryDataSmsAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderSuccessful == input.ProviderSuccessful ||
                    (this.ProviderSuccessful != null &&
                    this.ProviderSuccessful.Equals(input.ProviderSuccessful))
                ) && 
                (
                    this.ProviderFailed == input.ProviderFailed ||
                    (this.ProviderFailed != null &&
                    this.ProviderFailed.Equals(input.ProviderFailed))
                ) && 
                (
                    this.ProviderErrored == input.ProviderErrored ||
                    (this.ProviderErrored != null &&
                    this.ProviderErrored.Equals(input.ProviderErrored))
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
                if (this.ProviderSuccessful != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderSuccessful.GetHashCode();
                }
                if (this.ProviderFailed != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderFailed.GetHashCode();
                }
                if (this.ProviderErrored != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderErrored.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
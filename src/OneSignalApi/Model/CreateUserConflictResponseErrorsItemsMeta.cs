/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.2.1
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
    /// CreateUserConflictResponseErrorsItemsMeta
    /// </summary>
    [DataContract(Name = "CreateUserConflictResponse_errorsItems_meta")]
    public partial class CreateUserConflictResponseErrorsItemsMeta : IEquatable<CreateUserConflictResponseErrorsItemsMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserConflictResponseErrorsItemsMeta" /> class.
        /// </summary>
        /// <param name="conflictingAliases">conflictingAliases.</param>
        public CreateUserConflictResponseErrorsItemsMeta(Object conflictingAliases = default(Object))
        {
            this.ConflictingAliases = conflictingAliases;
        }

        /// <summary>
        /// Gets or Sets ConflictingAliases
        /// </summary>
        [DataMember(Name = "conflicting_aliases", EmitDefaultValue = false)]
        public Object ConflictingAliases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserConflictResponseErrorsItemsMeta {\n");
            sb.Append("  ConflictingAliases: ").Append(ConflictingAliases).Append("\n");
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
            return this.Equals(input as CreateUserConflictResponseErrorsItemsMeta);
        }

        /// <summary>
        /// Returns true if CreateUserConflictResponseErrorsItemsMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserConflictResponseErrorsItemsMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserConflictResponseErrorsItemsMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConflictingAliases == input.ConflictingAliases ||
                    (this.ConflictingAliases != null &&
                    this.ConflictingAliases.Equals(input.ConflictingAliases))
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
                if (this.ConflictingAliases != null)
                {
                    hashCode = (hashCode * 59) + this.ConflictingAliases.GetHashCode();
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

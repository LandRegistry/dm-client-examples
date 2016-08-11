using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AdditionalProvisionsInner :  IEquatable<AdditionalProvisionsInner>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalProvisionsInner" /> class.
        /// Initializes a new instance of the <see cref="AdditionalProvisionsInner" />class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="AdditionalProvisionCode">AdditionalProvisionCode.</param>

        public AdditionalProvisionsInner(string Description = null, string AdditionalProvisionCode = null)
        {
            this.Description = Description;
            this.AdditionalProvisionCode = AdditionalProvisionCode;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalProvisionCode
        /// </summary>
        [DataMember(Name="additional_provision_code", EmitDefaultValue=false)]
        public string AdditionalProvisionCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalProvisionsInner {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AdditionalProvisionCode: ").Append(AdditionalProvisionCode).Append("\n");
            
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AdditionalProvisionsInner);
        }

        /// <summary>
        /// Returns true if AdditionalProvisionsInner instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalProvisionsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalProvisionsInner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.AdditionalProvisionCode == other.AdditionalProvisionCode ||
                    this.AdditionalProvisionCode != null &&
                    this.AdditionalProvisionCode.Equals(other.AdditionalProvisionCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.AdditionalProvisionCode != null)
                    hash = hash * 59 + this.AdditionalProvisionCode.GetHashCode();
                
                return hash;
            }
        }

    }
}

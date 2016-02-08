using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ChargeClause :  IEquatable<ChargeClause>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeClause" /> class.
        /// </summary>
        public ChargeClause()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CreCode
        /// </summary>
        [DataMember(Name="cre_code", EmitDefaultValue=false)]
        public string CreCode { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeClause {\n");
            sb.Append("  CreCode: ").Append(CreCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            return this.Equals(obj as ChargeClause);
        }

        /// <summary>
        /// Returns true if ChargeClause instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeClause other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreCode == other.CreCode ||
                    this.CreCode != null &&
                    this.CreCode.Equals(other.CreCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                if (this.CreCode != null)
                    hash = hash * 57 + this.CreCode.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                return hash;
            }
        }

    }
}

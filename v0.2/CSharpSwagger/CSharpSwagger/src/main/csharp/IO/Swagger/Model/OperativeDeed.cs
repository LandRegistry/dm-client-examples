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
    public class OperativeDeed :  IEquatable<OperativeDeed>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperativeDeed" /> class.
        /// </summary>
        public OperativeDeed()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Deed
        /// </summary>
        [DataMember(Name="deed", EmitDefaultValue=false)]
        public OperativeDeedDeed Deed { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperativeDeed {\n");
            sb.Append("  Deed: ").Append(Deed).Append("\n");
            
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
            return this.Equals(obj as OperativeDeed);
        }

        /// <summary>
        /// Returns true if OperativeDeed instances are equal
        /// </summary>
        /// <param name="other">Instance of OperativeDeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperativeDeed other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Deed == other.Deed ||
                    this.Deed != null &&
                    this.Deed.Equals(other.Deed)
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
                
                if (this.Deed != null)
                    hash = hash * 57 + this.Deed.GetHashCode();
                
                return hash;
            }
        }

    }
}

/* 
 * Deed API
 *
 * Land Registry Deed API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
    /// OperativeDeed
    /// </summary>
    [DataContract]
    public partial class OperativeDeed :  IEquatable<OperativeDeed>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperativeDeed" /> class.
        /// </summary>
        /// <param name="Deed">Deed.</param>
        public OperativeDeed(OperativeDeedDeed Deed = null)
        {
            this.Deed = Deed;
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
                    hash = hash * 59 + this.Deed.GetHashCode();
                return hash;
            }
        }
    }

}

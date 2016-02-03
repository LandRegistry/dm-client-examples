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
    public class PrivateIndividualName :  IEquatable<PrivateIndividualName>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateIndividualName" /> class.
        /// </summary>
        public PrivateIndividualName()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Forename
        /// </summary>
        [DataMember(Name="forename", EmitDefaultValue=false)]
        public string Forename { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string Surname { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Dob
        /// </summary>
        [DataMember(Name="dob", EmitDefaultValue=false)]
        public string Dob { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateIndividualName {\n");
            sb.Append("  Forename: ").Append(Forename).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            
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
            return this.Equals(obj as PrivateIndividualName);
        }

        /// <summary>
        /// Returns true if PrivateIndividualName instances are equal
        /// </summary>
        /// <param name="other">Instance of PrivateIndividualName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateIndividualName other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Forename == other.Forename ||
                    this.Forename != null &&
                    this.Forename.Equals(other.Forename)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.Surname == other.Surname ||
                    this.Surname != null &&
                    this.Surname.Equals(other.Surname)
                ) && 
                (
                    this.Dob == other.Dob ||
                    this.Dob != null &&
                    this.Dob.Equals(other.Dob)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                
                if (this.Forename != null)
                    hash = hash * 57 + this.Forename.GetHashCode();
                
                if (this.MiddleName != null)
                    hash = hash * 57 + this.MiddleName.GetHashCode();
                
                if (this.Surname != null)
                    hash = hash * 57 + this.Surname.GetHashCode();
                
                if (this.Dob != null)
                    hash = hash * 57 + this.Dob.GetHashCode();
                
                if (this.Gender != null)
                    hash = hash * 57 + this.Gender.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 57 + this.PhoneNumber.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 57 + this.Address.GetHashCode();
                
                return hash;
            }
        }

    }
}

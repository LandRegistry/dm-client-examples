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
    public partial class DeedApplication :  IEquatable<DeedApplication>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeedApplication" /> class.
        /// Initializes a new instance of the <see cref="DeedApplication" />class.
        /// </summary>
        /// <param name="TitleNumber">TitleNumber (required).</param>
        /// <param name="Borrowers">Borrowers (required).</param>
        /// <param name="MdRef">MdRef (required).</param>
        /// <param name="IdentityChecked">IdentityChecked (required).</param>
        /// <param name="PropertyAddress">The address of property that the deed relates. This should be supplied in a comma separated format e.g. 30 wakefield rd, plymouth, PL6 3WA (required).</param>

        public DeedApplication(string TitleNumber = null, Borrowers Borrowers = null, string MdRef = null, string IdentityChecked = null, string PropertyAddress = null)
        {
            // to ensure "TitleNumber" is required (not null)
            if (TitleNumber == null)
            {
                throw new InvalidDataException("TitleNumber is a required property for DeedApplication and cannot be null");
            }
            else
            {
                this.TitleNumber = TitleNumber;
            }
            // to ensure "Borrowers" is required (not null)
            if (Borrowers == null)
            {
                throw new InvalidDataException("Borrowers is a required property for DeedApplication and cannot be null");
            }
            else
            {
                this.Borrowers = Borrowers;
            }
            // to ensure "MdRef" is required (not null)
            if (MdRef == null)
            {
                throw new InvalidDataException("MdRef is a required property for DeedApplication and cannot be null");
            }
            else
            {
                this.MdRef = MdRef;
            }
            // to ensure "IdentityChecked" is required (not null)
            if (IdentityChecked == null)
            {
                throw new InvalidDataException("IdentityChecked is a required property for DeedApplication and cannot be null");
            }
            else
            {
                this.IdentityChecked = IdentityChecked;
            }
            // to ensure "PropertyAddress" is required (not null)
            if (PropertyAddress == null)
            {
                throw new InvalidDataException("PropertyAddress is a required property for DeedApplication and cannot be null");
            }
            else
            {
                this.PropertyAddress = PropertyAddress;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets TitleNumber
        /// </summary>
        [DataMember(Name="title_number", EmitDefaultValue=false)]
        public string TitleNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Borrowers
        /// </summary>
        [DataMember(Name="borrowers", EmitDefaultValue=false)]
        public Borrowers Borrowers { get; set; }
    
        /// <summary>
        /// Gets or Sets MdRef
        /// </summary>
        [DataMember(Name="md_ref", EmitDefaultValue=false)]
        public string MdRef { get; set; }
    
        /// <summary>
        /// Gets or Sets IdentityChecked
        /// </summary>
        [DataMember(Name="identity_checked", EmitDefaultValue=false)]
        public string IdentityChecked { get; set; }
    
        /// <summary>
        /// The address of property that the deed relates. This should be supplied in a comma separated format e.g. 30 wakefield rd, plymouth, PL6 3WA
        /// </summary>
        /// <value>The address of property that the deed relates. This should be supplied in a comma separated format e.g. 30 wakefield rd, plymouth, PL6 3WA</value>
        [DataMember(Name="property_address", EmitDefaultValue=false)]
        public string PropertyAddress { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeedApplication {\n");
            sb.Append("  TitleNumber: ").Append(TitleNumber).Append("\n");
            sb.Append("  Borrowers: ").Append(Borrowers).Append("\n");
            sb.Append("  MdRef: ").Append(MdRef).Append("\n");
            sb.Append("  IdentityChecked: ").Append(IdentityChecked).Append("\n");
            sb.Append("  PropertyAddress: ").Append(PropertyAddress).Append("\n");
            
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
            return this.Equals(obj as DeedApplication);
        }

        /// <summary>
        /// Returns true if DeedApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of DeedApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeedApplication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TitleNumber == other.TitleNumber ||
                    this.TitleNumber != null &&
                    this.TitleNumber.Equals(other.TitleNumber)
                ) && 
                (
                    this.Borrowers == other.Borrowers ||
                    this.Borrowers != null &&
                    this.Borrowers.Equals(other.Borrowers)
                ) && 
                (
                    this.MdRef == other.MdRef ||
                    this.MdRef != null &&
                    this.MdRef.Equals(other.MdRef)
                ) && 
                (
                    this.IdentityChecked == other.IdentityChecked ||
                    this.IdentityChecked != null &&
                    this.IdentityChecked.Equals(other.IdentityChecked)
                ) && 
                (
                    this.PropertyAddress == other.PropertyAddress ||
                    this.PropertyAddress != null &&
                    this.PropertyAddress.Equals(other.PropertyAddress)
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
                
                if (this.TitleNumber != null)
                    hash = hash * 59 + this.TitleNumber.GetHashCode();
                
                if (this.Borrowers != null)
                    hash = hash * 59 + this.Borrowers.GetHashCode();
                
                if (this.MdRef != null)
                    hash = hash * 59 + this.MdRef.GetHashCode();
                
                if (this.IdentityChecked != null)
                    hash = hash * 59 + this.IdentityChecked.GetHashCode();
                
                if (this.PropertyAddress != null)
                    hash = hash * 59 + this.PropertyAddress.GetHashCode();
                
                return hash;
            }
        }

    }
}

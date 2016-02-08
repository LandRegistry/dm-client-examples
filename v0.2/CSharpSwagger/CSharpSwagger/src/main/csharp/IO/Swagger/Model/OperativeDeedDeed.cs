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
    /// Unique deed, consisting of property, borrower and charge information as well as clauses for the deed.
    /// </summary>
    [DataContract]
    public class OperativeDeedDeed :  IEquatable<OperativeDeedDeed>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperativeDeedDeed" /> class.
        /// </summary>
        public OperativeDeedDeed()
        {
            
        }

        
        /// <summary>
        /// Unique Land Registry identifier for the registered estate.
        /// </summary>
        /// <value>Unique Land Registry identifier for the registered estate.</value>
        [DataMember(Name="title_number", EmitDefaultValue=false)]
        public string TitleNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Lender
        /// </summary>
        [DataMember(Name="lender", EmitDefaultValue=false)]
        public Lender Lender { get; set; }
  
        
        /// <summary>
        /// The address of property that the deed relates. This should be supplied in a comma separated format e.g. 30 wakefield rd, plymouth, PL6 3WA
        /// </summary>
        /// <value>The address of property that the deed relates. This should be supplied in a comma separated format e.g. 30 wakefield rd, plymouth, PL6 3WA</value>
        [DataMember(Name="property_address", EmitDefaultValue=false)]
        public string PropertyAddress { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AdditionalProvisions
        /// </summary>
        [DataMember(Name="additional_provisions", EmitDefaultValue=false)]
        public AdditionalProvisions AdditionalProvisions { get; set; }
  
        
        /// <summary>
        /// Land Registry assigned number for a Mortgage Deed (MD). If you wish to use an existing MD reference please prefix it with e- to comply with our system (eg e-MD12345)
        /// </summary>
        /// <value>Land Registry assigned number for a Mortgage Deed (MD). If you wish to use an existing MD reference please prefix it with e- to comply with our system (eg e-MD12345)</value>
        [DataMember(Name="md_ref", EmitDefaultValue=false)]
        public string MdRef { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Borrowers
        /// </summary>
        [DataMember(Name="borrowers", EmitDefaultValue=false)]
        public Borrowers Borrowers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ChargeClause
        /// </summary>
        [DataMember(Name="charge_clause", EmitDefaultValue=false)]
        public ChargeClause ChargeClause { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperativeDeedDeed {\n");
            sb.Append("  TitleNumber: ").Append(TitleNumber).Append("\n");
            sb.Append("  Lender: ").Append(Lender).Append("\n");
            sb.Append("  PropertyAddress: ").Append(PropertyAddress).Append("\n");
            sb.Append("  AdditionalProvisions: ").Append(AdditionalProvisions).Append("\n");
            sb.Append("  MdRef: ").Append(MdRef).Append("\n");
            sb.Append("  Borrowers: ").Append(Borrowers).Append("\n");
            sb.Append("  ChargeClause: ").Append(ChargeClause).Append("\n");
            
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
            return this.Equals(obj as OperativeDeedDeed);
        }

        /// <summary>
        /// Returns true if OperativeDeedDeed instances are equal
        /// </summary>
        /// <param name="other">Instance of OperativeDeedDeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperativeDeedDeed other)
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
                    this.Lender == other.Lender ||
                    this.Lender != null &&
                    this.Lender.Equals(other.Lender)
                ) && 
                (
                    this.PropertyAddress == other.PropertyAddress ||
                    this.PropertyAddress != null &&
                    this.PropertyAddress.Equals(other.PropertyAddress)
                ) && 
                (
                    this.AdditionalProvisions == other.AdditionalProvisions ||
                    this.AdditionalProvisions != null &&
                    this.AdditionalProvisions.Equals(other.AdditionalProvisions)
                ) && 
                (
                    this.MdRef == other.MdRef ||
                    this.MdRef != null &&
                    this.MdRef.Equals(other.MdRef)
                ) && 
                (
                    this.Borrowers == other.Borrowers ||
                    this.Borrowers != null &&
                    this.Borrowers.Equals(other.Borrowers)
                ) && 
                (
                    this.ChargeClause == other.ChargeClause ||
                    this.ChargeClause != null &&
                    this.ChargeClause.Equals(other.ChargeClause)
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
                    hash = hash * 57 + this.TitleNumber.GetHashCode();
                
                if (this.Lender != null)
                    hash = hash * 57 + this.Lender.GetHashCode();
                
                if (this.PropertyAddress != null)
                    hash = hash * 57 + this.PropertyAddress.GetHashCode();
                
                if (this.AdditionalProvisions != null)
                    hash = hash * 57 + this.AdditionalProvisions.GetHashCode();
                
                if (this.MdRef != null)
                    hash = hash * 57 + this.MdRef.GetHashCode();
                
                if (this.Borrowers != null)
                    hash = hash * 57 + this.Borrowers.GetHashCode();
                
                if (this.ChargeClause != null)
                    hash = hash * 57 + this.ChargeClause.GetHashCode();
                
                return hash;
            }
        }

    }
}

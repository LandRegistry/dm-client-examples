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
    public partial class Borrower :  IEquatable<Borrower>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Borrower" /> class.
        /// Initializes a new instance of the <see cref="Borrower" />class.
        /// </summary>
        /// <param name="Forename">Forename (required).</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="Surname">Surname (required).</param>
        /// <param name="Token">Token (required).</param>
        /// <param name="Id">Id (required).</param>

        public Borrower(string Forename = null, string MiddleName = null, string Surname = null, string Token = null, string Id = null)
        {
            // to ensure "Forename" is required (not null)
            if (Forename == null)
            {
                throw new InvalidDataException("Forename is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Forename = Forename;
            }
            // to ensure "Surname" is required (not null)
            if (Surname == null)
            {
                throw new InvalidDataException("Surname is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Surname = Surname;
            }
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.MiddleName = MiddleName;
            
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
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Borrower {\n");
            sb.Append("  Forename: ").Append(Forename).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as Borrower);
        }

        /// <summary>
        /// Returns true if Borrower instances are equal
        /// </summary>
        /// <param name="other">Instance of Borrower to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Borrower other)
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
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    hash = hash * 59 + this.Forename.GetHashCode();
                
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                
                if (this.Surname != null)
                    hash = hash * 59 + this.Surname.GetHashCode();
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }

    }
}

using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PrivateIndividualName {
    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

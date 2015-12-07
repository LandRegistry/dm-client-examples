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
  public class OperativeDeed {
    
    /// <summary>
    /// Unique Land Registry identifier for the registered estate.
    /// </summary>
    /// <value>Unique Land Registry identifier for the registered estate.</value>
    [DataMember(Name="title_number", EmitDefaultValue=false)]
    public string TitleNumber { get; set; }

    
    /// <summary>
    /// Land Registry assigned number for a Mortgage Deed (MD)
    /// </summary>
    /// <value>Land Registry assigned number for a Mortgage Deed (MD)</value>
    [DataMember(Name="md_ref", EmitDefaultValue=false)]
    public string MdRef { get; set; }

    
    /// <summary>
    /// Gets or Sets Borrowers
    /// </summary>
    [DataMember(Name="borrowers", EmitDefaultValue=false)]
    public Borrowers Borrowers { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperativeDeed {\n");
      
      sb.Append("  TitleNumber: ").Append(TitleNumber).Append("\n");
      
      sb.Append("  MdRef: ").Append(MdRef).Append("\n");
      
      sb.Append("  Borrowers: ").Append(Borrowers).Append("\n");
      
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

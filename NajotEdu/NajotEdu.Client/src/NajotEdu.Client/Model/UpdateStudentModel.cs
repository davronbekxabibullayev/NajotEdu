/*
 * NajotEdu
 *
 * NajotEdu description
 *
 * The version of the OpenAPI document: V1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using FileParameter = NajotEdu.Client.Client.FileParameter;
using OpenAPIDateConverter = NajotEdu.Client.Client.OpenAPIDateConverter;

namespace NajotEdu.Client.Model
{
    /// <summary>
    /// UpdateStudentModel
    /// </summary>
    [DataContract(Name = "UpdateStudentModel")]
    public partial class UpdateStudentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStudentModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        public UpdateStudentModel(int id = default(int), string fullName = default(string), DateTime birthDate = default(DateTime), string phoneNumber = default(string))
        {
            this.Id = id;
            this.FullName = fullName;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateStudentModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    }

}

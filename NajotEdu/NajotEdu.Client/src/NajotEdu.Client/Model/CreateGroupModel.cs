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
    /// CreateGroupModel
    /// </summary>
    [DataContract(Name = "CreateGroupModel")]
    public partial class CreateGroupModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="teacherId">teacherId.</param>
        /// <param name="lessonStartTime">lessonStartTime.</param>
        /// <param name="lessonEndTime">lessonEndTime.</param>
        public CreateGroupModel(string name = default(string), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), int teacherId = default(int), TimeSpan lessonStartTime = default(TimeSpan), TimeSpan lessonEndTime = default(TimeSpan))
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TeacherId = teacherId;
            this.LessonStartTime = lessonStartTime;
            this.LessonEndTime = lessonEndTime;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets TeacherId
        /// </summary>
        [DataMember(Name = "teacherId", EmitDefaultValue = false)]
        public int TeacherId { get; set; }

        /// <summary>
        /// Gets or Sets LessonStartTime
        /// </summary>
        [DataMember(Name = "lessonStartTime", EmitDefaultValue = false)]
        public TimeSpan LessonStartTime { get; set; }

        /// <summary>
        /// Gets or Sets LessonEndTime
        /// </summary>
        [DataMember(Name = "lessonEndTime", EmitDefaultValue = false)]
        public TimeSpan LessonEndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TeacherId: ").Append(TeacherId).Append("\n");
            sb.Append("  LessonStartTime: ").Append(LessonStartTime).Append("\n");
            sb.Append("  LessonEndTime: ").Append(LessonEndTime).Append("\n");
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

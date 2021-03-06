// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Output directory for the job.
    /// </summary>
    public partial class OutputDirectory
    {
        /// <summary>
        /// Initializes a new instance of the OutputDirectory class.
        /// </summary>
        public OutputDirectory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OutputDirectory class.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <param name="pathPrefix">Path prefix.</param>
        /// <param name="pathSuffix">Path suffix.</param>
        public OutputDirectory(string id, string pathPrefix, string pathSuffix = default(string))
        {
            Id = id;
            PathPrefix = pathPrefix;
            PathSuffix = pathSuffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        /// <remarks>
        /// The ID of the output directory. The job can use
        /// AZ_BATCHAI_OUTPUT_<id> environment variale to find the directory
        /// path, where <id> is the value of id attribute.
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets path prefix.
        /// </summary>
        /// <remarks>
        /// The prefix path where the output directory will be created. Note,
        /// this is an absolute path to prefix. E.g.
        /// $AZ_BATCHAI_MOUNT_ROOT/MyNFS/MyLogs. The full path to the output
        /// directory by combining pathPrefix, jobOutputDirectoryPathSegment
        /// (reported by get job) and pathSuffix.
        /// </remarks>
        [JsonProperty(PropertyName = "pathPrefix")]
        public string PathPrefix { get; set; }

        /// <summary>
        /// Gets or sets path suffix.
        /// </summary>
        /// <remarks>
        /// The suffix path where the output directory will be created. E.g.
        /// models. You can find the full path to the output directory by
        /// combining pathPrefix, jobOutputDirectoryPathSegment (reported by
        /// get job) and pathSuffix.
        /// </remarks>
        [JsonProperty(PropertyName = "pathSuffix")]
        public string PathSuffix { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (PathPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PathPrefix");
            }
        }
    }
}

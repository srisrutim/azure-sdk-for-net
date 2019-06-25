// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Authorization tuple containing principal Id (of user/service
    /// principal/security group) and role definition id.
    /// </summary>
    public partial class Authorization
    {
        /// <summary>
        /// Initializes a new instance of the Authorization class.
        /// </summary>
        public Authorization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Authorization class.
        /// </summary>
        /// <param name="principalId">Principal Id of the security
        /// group/service principal/user that would be assigned permissions to
        /// the projected subscription</param>
        /// <param name="roleDefinitionId">The role definition identifier. This
        /// role will define all the permissions that the security
        /// group/service principal/user must have on the projected
        /// subscription. This role cannot be an owner role.</param>
        public Authorization(string principalId, string roleDefinitionId)
        {
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets principal Id of the security group/service
        /// principal/user that would be assigned permissions to the projected
        /// subscription
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the role definition identifier. This role will define
        /// all the permissions that the security group/service principal/user
        /// must have on the projected subscription. This role cannot be an
        /// owner role.
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrincipalId");
            }
            if (RoleDefinitionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleDefinitionId");
            }
        }
    }
}
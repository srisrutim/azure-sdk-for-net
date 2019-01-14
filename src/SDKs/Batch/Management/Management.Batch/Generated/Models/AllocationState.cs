// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AllocationState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllocationState
    {
        /// <summary>
        /// The pool is not resizing. There are no changes to the number of
        /// nodes in the pool in progress. A pool enters this state when it is
        /// created and when no operations are being performed on the pool to
        /// change the number of nodes.
        /// </summary>
        [EnumMember(Value = "Steady")]
        Steady,
        /// <summary>
        /// The pool is resizing; that is, compute nodes are being added to or
        /// removed from the pool.
        /// </summary>
        [EnumMember(Value = "Resizing")]
        Resizing,
        /// <summary>
        /// The pool was resizing, but the user has requested that the resize
        /// be stopped, but the stop request has not yet been completed.
        /// </summary>
        [EnumMember(Value = "Stopping")]
        Stopping
    }
    internal static class AllocationStateEnumExtension
    {
        internal static string ToSerializedValue(this AllocationState? value)
        {
            return value == null ? null : ((AllocationState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AllocationState value)
        {
            switch( value )
            {
                case AllocationState.Steady:
                    return "Steady";
                case AllocationState.Resizing:
                    return "Resizing";
                case AllocationState.Stopping:
                    return "Stopping";
            }
            return null;
        }

        internal static AllocationState? ParseAllocationState(this string value)
        {
            switch( value )
            {
                case "Steady":
                    return AllocationState.Steady;
                case "Resizing":
                    return AllocationState.Resizing;
                case "Stopping":
                    return AllocationState.Stopping;
            }
            return null;
        }
    }
}

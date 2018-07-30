// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for VirtualMachinePriorityTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(VirtualMachinePriorityTypesConverter))]
    public struct VirtualMachinePriorityTypes : System.IEquatable<VirtualMachinePriorityTypes>
    {
        private VirtualMachinePriorityTypes(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly VirtualMachinePriorityTypes Regular = "Regular";

        public static readonly VirtualMachinePriorityTypes Low = "Low";


        /// <summary>
        /// Underlying value of enum VirtualMachinePriorityTypes
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for VirtualMachinePriorityTypes
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type VirtualMachinePriorityTypes
        /// </summary>
        public bool Equals(VirtualMachinePriorityTypes e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to VirtualMachinePriorityTypes
        /// </summary>
        public static implicit operator VirtualMachinePriorityTypes(string value)
        {
            return new VirtualMachinePriorityTypes(value);
        }

        /// <summary>
        /// Implicit operator to convert VirtualMachinePriorityTypes to string
        /// </summary>
        public static implicit operator string(VirtualMachinePriorityTypes e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum VirtualMachinePriorityTypes
        /// </summary>
        public static bool operator == (VirtualMachinePriorityTypes e1, VirtualMachinePriorityTypes e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum VirtualMachinePriorityTypes
        /// </summary>
        public static bool operator != (VirtualMachinePriorityTypes e1, VirtualMachinePriorityTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for VirtualMachinePriorityTypes
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is VirtualMachinePriorityTypes && Equals((VirtualMachinePriorityTypes)obj);
        }

        /// <summary>
        /// Returns for hashCode VirtualMachinePriorityTypes
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}

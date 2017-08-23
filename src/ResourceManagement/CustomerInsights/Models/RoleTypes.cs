// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RoleTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoleTypes
    {
        [EnumMember(Value = "Admin")]
        Admin,
        [EnumMember(Value = "Reader")]
        Reader,
        [EnumMember(Value = "ManageAdmin")]
        ManageAdmin,
        [EnumMember(Value = "ManageReader")]
        ManageReader,
        [EnumMember(Value = "DataAdmin")]
        DataAdmin,
        [EnumMember(Value = "DataReader")]
        DataReader
    }
    internal static class RoleTypesEnumExtension
    {
        internal static string ToSerializedValue(this RoleTypes? value)
        {
            return value == null ? null : ((RoleTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RoleTypes value)
        {
            switch( value )
            {
                case RoleTypes.Admin:
                    return "Admin";
                case RoleTypes.Reader:
                    return "Reader";
                case RoleTypes.ManageAdmin:
                    return "ManageAdmin";
                case RoleTypes.ManageReader:
                    return "ManageReader";
                case RoleTypes.DataAdmin:
                    return "DataAdmin";
                case RoleTypes.DataReader:
                    return "DataReader";
            }
            return null;
        }

        internal static RoleTypes? ParseRoleTypes(this string value)
        {
            switch( value )
            {
                case "Admin":
                    return RoleTypes.Admin;
                case "Reader":
                    return RoleTypes.Reader;
                case "ManageAdmin":
                    return RoleTypes.ManageAdmin;
                case "ManageReader":
                    return RoleTypes.ManageReader;
                case "DataAdmin":
                    return RoleTypes.DataAdmin;
                case "DataReader":
                    return RoleTypes.DataReader;
            }
            return null;
        }
    }
}
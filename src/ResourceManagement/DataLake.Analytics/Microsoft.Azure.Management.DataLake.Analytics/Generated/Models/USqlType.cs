// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL type item.
    /// </summary>
    public partial class USqlType : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlType class.
        /// </summary>
        public USqlType() { }

        /// <summary>
        /// Initializes a new instance of the USqlType class.
        /// </summary>
        public USqlType(string computeAccountName = default(string), string version = default(string), string databaseName = default(string), string schemaName = default(string), string typeName = default(string), string typeFamily = default(string), string cSharpName = default(string), string fullCSharpName = default(string), int? systemTypeId = default(int?), int? userTypeId = default(int?), int? schemaId = default(int?), int? principalId = default(int?), bool? isNullable = default(bool?), bool? isUserDefined = default(bool?), bool? isAssemblyType = default(bool?), bool? isTableType = default(bool?), bool? isComplexType = default(bool?))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            TypeName = typeName;
            TypeFamily = typeFamily;
            CSharpName = cSharpName;
            FullCSharpName = fullCSharpName;
            SystemTypeId = systemTypeId;
            UserTypeId = userTypeId;
            SchemaId = schemaId;
            PrincipalId = principalId;
            IsNullable = isNullable;
            IsUserDefined = isUserDefined;
            IsAssemblyType = isAssemblyType;
            IsTableType = isTableType;
            IsComplexType = isComplexType;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this table and
        /// database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of type for this type.
        /// </summary>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the type family for this type.
        /// </summary>
        [JsonProperty(PropertyName = "typeFamily")]
        public string TypeFamily { get; set; }

        /// <summary>
        /// Gets or sets the C# name for this type.
        /// </summary>
        [JsonProperty(PropertyName = "cSharpName")]
        public string CSharpName { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified C# name for this type.
        /// </summary>
        [JsonProperty(PropertyName = "fullCSharpName")]
        public string FullCSharpName { get; set; }

        /// <summary>
        /// Gets or sets the system type ID for this type.
        /// </summary>
        [JsonProperty(PropertyName = "systemTypeId")]
        public int? SystemTypeId { get; set; }

        /// <summary>
        /// Gets or sets the user type ID for this type.
        /// </summary>
        [JsonProperty(PropertyName = "userTypeId")]
        public int? UserTypeId { get; set; }

        /// <summary>
        /// Gets or sets the schema ID for this type.
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public int? SchemaId { get; set; }

        /// <summary>
        /// Gets or sets the principal ID for this type.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public int? PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the the switch indicating if this type is nullable.
        /// </summary>
        [JsonProperty(PropertyName = "isNullable")]
        public bool? IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the the switch indicating if this type is user
        /// defined.
        /// </summary>
        [JsonProperty(PropertyName = "isUserDefined")]
        public bool? IsUserDefined { get; set; }

        /// <summary>
        /// Gets or sets the the switch indicating if this type is an assembly
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "isAssemblyType")]
        public bool? IsAssemblyType { get; set; }

        /// <summary>
        /// Gets or sets the the switch indicating if this type is a table
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "isTableType")]
        public bool? IsTableType { get; set; }

        /// <summary>
        /// Gets or sets the the switch indicating if this type is a complex
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "isComplexType")]
        public bool? IsComplexType { get; set; }

    }
}

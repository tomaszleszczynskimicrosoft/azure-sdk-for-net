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
    /// A Data Lake Analytics account object, containing all information
    /// associated with the named Data Lake Analytics account.
    /// </summary>
    public partial class DataLakeAnalyticsAccount
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        public DataLakeAnalyticsAccount() { }

        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        public DataLakeAnalyticsAccount(string location = default(string), string name = default(string), string type = default(string), string id = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DataLakeAnalyticsAccountProperties properties = default(DataLakeAnalyticsAccountProperties))
        {
            Location = location;
            Name = name;
            Type = type;
            Id = id;
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the account regional location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the namespace and type of the account.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the account subscription ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the value of custom properties.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the properties defined by Data Lake Analytics all
        /// properties are specific to each resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DataLakeAnalyticsAccountProperties Properties { get; set; }

    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// My new very important property definition.
    /// </summary>
    public partial class VeryImportantNewPropertyName
    {
        /// <summary>
        /// Initializes a new instance of the VeryImportantNewPropertyName
        /// class.
        /// </summary>
        public VeryImportantNewPropertyName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VeryImportantNewPropertyName
        /// class.
        /// </summary>
        /// <param name="someSetting">Setting name.</param>
        public VeryImportantNewPropertyName(string someSetting = default(string))
        {
            SomeSetting = someSetting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets setting name.
        /// </summary>
        [JsonProperty(PropertyName = "someSetting")]
        public string SomeSetting { get; set; }

    }
}

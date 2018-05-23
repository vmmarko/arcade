// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ViewConfigurationSource
    {
        /// <summary>
        /// Initializes a new instance of the ViewConfigurationSource class.
        /// </summary>
        public ViewConfigurationSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ViewConfigurationSource class.
        /// </summary>
        public ViewConfigurationSource(string repository = default(string), string branch = default(string), string milestone = default(string), bool? sortByBuild = default(bool?), IList<ViewConfigurationExternalTelemetry> releaseLinks = default(IList<ViewConfigurationExternalTelemetry>), IList<ViewConfigurationType> types = default(IList<ViewConfigurationType>), IList<ViewConfigurationExternalTelemetry> externalLinks = default(IList<ViewConfigurationExternalTelemetry>), IDictionary<string, string> buildProperties = default(IDictionary<string, string>), string name = default(string), string displayName = default(string))
        {
            Repository = repository;
            Branch = branch;
            Milestone = milestone;
            SortByBuild = sortByBuild;
            ReleaseLinks = releaseLinks;
            Types = types;
            ExternalLinks = externalLinks;
            BuildProperties = buildProperties;
            Name = name;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "milestone")]
        public string Milestone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sortByBuild")]
        public bool? SortByBuild { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "releaseLinks")]
        public IList<ViewConfigurationExternalTelemetry> ReleaseLinks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public IList<ViewConfigurationType> Types { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "externalLinks")]
        public IList<ViewConfigurationExternalTelemetry> ExternalLinks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "buildProperties")]
        public IDictionary<string, string> BuildProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
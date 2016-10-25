// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies which redis node(s) to reboot.
    /// </summary>
    public partial class RedisRebootParameters
    {
        /// <summary>
        /// Initializes a new instance of the RedisRebootParameters class.
        /// </summary>
        public RedisRebootParameters() { }

        /// <summary>
        /// Initializes a new instance of the RedisRebootParameters class.
        /// </summary>
        /// <param name="rebootType">Which redis node(s) to reboot. Depending
        /// on this value data loss is possible. Possible values include:
        /// 'PrimaryNode', 'SecondaryNode', 'AllNodes'</param>
        /// <param name="shardId">In case of cluster cache, this specifies
        /// shard id which should be rebooted.</param>
        public RedisRebootParameters(string rebootType, int? shardId = default(int?))
        {
            RebootType = rebootType;
            ShardId = shardId;
        }

        /// <summary>
        /// Gets or sets which redis node(s) to reboot. Depending on this
        /// value data loss is possible. Possible values include:
        /// 'PrimaryNode', 'SecondaryNode', 'AllNodes'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rebootType")]
        public string RebootType { get; set; }

        /// <summary>
        /// Gets or sets in case of cluster cache, this specifies shard id
        /// which should be rebooted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "shardId")]
        public int? ShardId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RebootType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RebootType");
            }
        }
    }
}

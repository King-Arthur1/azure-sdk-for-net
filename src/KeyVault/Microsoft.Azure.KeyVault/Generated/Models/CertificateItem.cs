// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class CertificateItem
    {
        /// <summary>
        /// Initializes a new instance of the CertificateItem class.
        /// </summary>
        public CertificateItem() { }

        /// <summary>
        /// Initializes a new instance of the CertificateItem class.
        /// </summary>
        /// <param name="id">Certificate Identifier</param>
        /// <param name="attributes">The certificate management attributes</param>
        /// <param name="tags">Application-specific metadata in the form of key-value pairs</param>
        /// <param name="x5T">Thumbprint of the certificate.</param>
        public CertificateItem(string id = default(string), CertificateAttributes attributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), byte[] x5T = default(byte[]))
        {
            Id = id;
            Attributes = attributes;
            Tags = tags;
            X5T = x5T;
        }

        /// <summary>
        /// Gets or sets certificate Identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the certificate management attributes
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public CertificateAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of
        /// key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets thumbprint of the certificate.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "x5t")]
        public byte[] X5T { get; set; }

    }
}

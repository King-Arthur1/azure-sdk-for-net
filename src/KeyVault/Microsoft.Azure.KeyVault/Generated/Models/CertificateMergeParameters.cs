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

    public partial class CertificateMergeParameters
    {
        /// <summary>
        /// Initializes a new instance of the CertificateMergeParameters class.
        /// </summary>
        public CertificateMergeParameters() { }

        /// <summary>
        /// Initializes a new instance of the CertificateMergeParameters class.
        /// </summary>
        /// <param name="x509Certificates">The certificate or the certificte chain to merge</param>
        /// <param name="certificateAttributes">The attributes of the certificate (optional)</param>
        /// <param name="tags">Application-specific metadata in the form of key-value pairs</param>
        public CertificateMergeParameters(IList<byte[]> x509Certificates, CertificateAttributes certificateAttributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            X509Certificates = x509Certificates;
            CertificateAttributes = certificateAttributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets the certificate or the certificte chain to merge
        /// </summary>
        [JsonProperty(PropertyName = "x5c")]
        public IList<byte[]> X509Certificates { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the certificate (optional)
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public CertificateAttributes CertificateAttributes { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of
        /// key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (X509Certificates == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "X509Certificates");
            }
        }
    }
}

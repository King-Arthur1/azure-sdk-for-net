// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class OAuth2PermissionGrantListResult
    {
        internal static OAuth2PermissionGrantListResult DeserializeOAuth2PermissionGrantListResult(JsonElement element)
        {
            Optional<IReadOnlyList<OAuth2PermissionGrant>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<OAuth2PermissionGrant> array = new List<OAuth2PermissionGrant>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OAuth2PermissionGrant.DeserializeOAuth2PermissionGrant(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new OAuth2PermissionGrantListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}

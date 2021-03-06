// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AvailableDelegationsResult
    {
        internal static AvailableDelegationsResult DeserializeAvailableDelegationsResult(JsonElement element)
        {
            Optional<IReadOnlyList<AvailableDelegation>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AvailableDelegation> array = new List<AvailableDelegation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableDelegation.DeserializeAvailableDelegation(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AvailableDelegationsResult(Optional.ToList(value), nextLink.Value);
        }
    }
}

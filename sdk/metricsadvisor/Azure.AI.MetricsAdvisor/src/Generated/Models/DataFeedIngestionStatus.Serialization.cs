// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataFeedIngestionStatus
    {
        internal static DataFeedIngestionStatus DeserializeDataFeedIngestionStatus(JsonElement element)
        {
            DateTimeOffset timestamp = default;
            IngestionStatusType status = default;
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new IngestionStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new DataFeedIngestionStatus(timestamp, status, message);
        }
    }
}

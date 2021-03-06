// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class InfluxDBParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("connectionString");
            writer.WriteStringValue(ConnectionString);
            writer.WritePropertyName("database");
            writer.WriteStringValue(Database);
            writer.WritePropertyName("userName");
            writer.WriteStringValue(UserName);
            writer.WritePropertyName("password");
            writer.WriteStringValue(Password);
            writer.WritePropertyName("query");
            writer.WriteStringValue(Query);
            writer.WriteEndObject();
        }

        internal static InfluxDBParameter DeserializeInfluxDBParameter(JsonElement element)
        {
            string connectionString = default;
            string database = default;
            string userName = default;
            string password = default;
            string query = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"))
                {
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new InfluxDBParameter(connectionString, database, userName, password, query);
        }
    }
}

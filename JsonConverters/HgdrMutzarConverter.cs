using IHubWebApplication.Model;
using Microsoft.Extensions.Options;
using System.Numerics;
using System.Text.Json;
using System;
using System.Text.Json.Serialization;

namespace IHubWebApplication.JsonConverters
{
    public class HgdrMutzarConverter : JsonConverter<HgdrMutzar>
    {
        public override HgdrMutzar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            HgdrMutzar mutzar = new HgdrMutzar();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return mutzar;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "id":
                            mutzar.Id = reader.GetInt32();
                            break;
                        case "kodSugMutzar":
                            mutzar.KodSugMutzar = reader.GetInt32();
                            break;
                        case "KodMutzarCategory":
                            mutzar.KodMutzarCategory = reader.GetInt32();
                            break;
                        case "mutzar":
                            mutzar.Mutzar = reader.GetString();
                            break;
                            // Handle other properties here
                    }
                }
            }
            return mutzar;
           // throw new JsonException("Incomplete JSON data for HgdrMutzar.");
        }

        public override void Write(Utf8JsonWriter writer, HgdrMutzar value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("id", value.Id);
            writer.WriteString("mutzar", value.Mutzar);
            writer.WriteNumber("kodSugMutzar", value.KodSugMutzar);
            if(value.KodMutzarCategory != null)
            writer.WriteNumber("kodMutzarCategory", value.KodMutzarCategory.Value);
            // You can write other properties here

            // Ignore navigation properties
            // writer.WriteNull("KodMutzarCategoryNavigation");
            // writer.WriteNull("KodSugMutzarNavigation");

            writer.WriteEndObject();
        }
    }






}

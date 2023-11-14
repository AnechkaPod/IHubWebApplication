using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IHubWebApplication.JsonConverters
{
    //public class NavigationPropertyIgnoreConverter<T> : JsonConverter<T>
    //{
    //    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType != JsonTokenType.StartObject)
    //        {
    //            throw new JsonException();
    //        }

    //        T entity = Activator.CreateInstance<T>();

    //        while (reader.Read())
    //        {
    //            if (reader.TokenType == JsonTokenType.EndObject)
    //            {
    //                return entity;
    //            }

    //            if (reader.TokenType == JsonTokenType.PropertyName)
    //            {
    //                string propertyName = reader.GetString();
    //                reader.Read();

    //                if (!propertyName.Contains("Navigation"))
    //                {
    //                    PropertyInfo property = typeof(T).GetProperty(propertyName);
    //                    if (property != null)
    //                    {
    //                        if (property.PropertyType == typeof(int))
    //                        {
    //                            int intValue = reader.GetInt32();
    //                            property.SetValue(entity, intValue);
    //                        }
    //                        else if (property.PropertyType == typeof(string))
    //                        {
    //                            string strValue = reader.GetString();
    //                            property.SetValue(entity, strValue);
    //                        }
    //                        // Add more property type cases as needed
    //                    }
    //                }
    //            }
    //        }
    //        return entity;
    //    }

    //    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStartObject();

    //        foreach (var property in typeof(T).GetProperties())
    //        {
    //            if (!property.Name.Contains("Navigation"))
    //            {
    //                var propertyValue = property.GetValue(value);
    //                if (propertyValue != null)
    //                {
    //                    writer.WriteStartObject();
    //                    writer.WriteEndObject();
    //                }
    //            }
    //        }

    //        writer.WriteEndObject();
    //    }
    //}
}

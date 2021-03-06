//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonConverterGenerator
{
    public sealed class JsonConverterForLoginViewModel : JsonConverter<LoginViewModel>
    {
        private JsonConverterForLoginViewModel() {}
        
        public static readonly JsonConverterForLoginViewModel Instance = new JsonConverterForLoginViewModel();
        
        private static ulong EmailKey = 360288435814100293;
        private static JsonEncodedText EmailText = JsonEncodedText.Encode("Email", encoder: null);
        
        private static ulong PasswordKey = 18406897185845371216;
        private static JsonEncodedText PasswordText = JsonEncodedText.Encode("Password", encoder: null);
        
        private static ulong RememberMeKey = 18403223674312025426;
        private static JsonEncodedText RememberMeText = JsonEncodedText.Encode("RememberMe", encoder: null);
        
        
        public override LoginViewModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Validate that the reader's cursor is at a start object token.
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }
            
            // Create returned object. This assumes type has public parameterless ctor.
            LoginViewModel value = new LoginViewModel();
            
            // Read all properties.
            while (true)
            {
                reader.Read();
                
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }
                
                // Only unescaped property names are allowed.
                ReadOnlySpan<byte> propertyName = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
                
                // Move reader cursor to property value.
                reader.Read();
                
                // Try to match property name with object properties (case sensitive).
                
                // Determine if JSON property matches 'Email'.
                if (Helpers.GetKey(propertyName) == EmailKey)
                {
                    value.Email = reader.GetString();
                }
                // Determine if JSON property matches 'Password'.
                else if (Helpers.GetKey(propertyName) == PasswordKey)
                {
                    value.Password = reader.GetString();
                }
                // Determine if JSON property matches 'RememberMe'.
                else if (Helpers.GetKey(propertyName) == RememberMeKey)
                {
                    value.RememberMe = reader.GetBoolean();
                }
            }
            
            return value;
        }
        
        public override void Write(Utf8JsonWriter writer, LoginViewModel value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
            
            writer.WriteStartObject();
            
            writer.WriteString(EmailText, value.Email);
            
            writer.WriteString(PasswordText, value.Password);
            
            writer.WriteBoolean(RememberMeText, value.RememberMe);
            
            writer.WriteEndObject();
        }
    }
}

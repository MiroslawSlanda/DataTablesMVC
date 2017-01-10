using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Infrastructure
{
    internal class FunctionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(String));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if(value != null)
            {
                string valueAsString = Convert.ToString(value);
                if (!string.IsNullOrWhiteSpace(valueAsString))
                    writer.WriteRawValue(valueAsString);
            }
        }
    }
}

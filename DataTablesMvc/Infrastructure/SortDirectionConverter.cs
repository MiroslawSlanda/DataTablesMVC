using Newtonsoft.Json;
using System;
using System.Web.Helpers;

namespace DataTablesMvc.Infrastructure
{
    internal class SortDirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(String));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (Convert.ToString(existingValue))
            {
                case "asc":
                    return SortDirection.Ascending;
                case "desc":
                    return SortDirection.Descending;
                default:
                    return SortDirection.Ascending;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
            
        }
    }
}

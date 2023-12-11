using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DPEnergy.CommonLayer.PublicClass
{
   

    public class JsonHelper
    {
        public static string RemoveInvalidJsonCharacters(string input)
        {
            // Remove characters that are not valid in JSON and replace them with spaces
            string sanitizedInput = Regex.Replace(input, @"[^\x20-\x7E]", "");
            return sanitizedInput;
        }
        public static void SanitizeStringProperties(object model)
        {
            var properties = model.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(string))
                {
                    var value = (string)property.GetValue(model);
                    if (value != null)
                    {
                        var sanitizedValue = JsonHelper.RemoveInvalidJsonCharacters(value);
                        property.SetValue(model, sanitizedValue);
                    }
                }
            }
        }
    }
    
}

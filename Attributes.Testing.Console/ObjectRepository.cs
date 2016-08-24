using System;
using System.Collections.Generic;
using System.Reflection;
using Attributes.Testing.Console.Attributes;

namespace Attributes.Testing.Console
{
    public class ObjectRepository
    {
        public static T GetObject<T>(Dictionary<string, object> propDic) where T : ICanBeGenerated, new() 
        {
            var inst = new T();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attribute = Attribute.GetCustomAttribute(property, typeof(PropertyValueAttribute)) as PropertyValueAttribute;

                if (attribute != null && propDic.ContainsKey(attribute.Name) && property.PropertyType == propDic[attribute.Name].GetType())
                    property.SetValue(inst, propDic[attribute.Name], null);
                else
                    SetDefaultValues(attribute,property, inst);
            
                
            }
            return inst;
        }

        private static void SetDefaultValues<T>(PropertyValueAttribute attribute, PropertyInfo property, T inst) where T : new()
        {
            if (attribute.Value != null && property.PropertyType == attribute.Value.GetType())
                property.SetValue(inst, attribute.Value, null); // null means no indexes
            else if (property.PropertyType == typeof (string))
                property.SetValue(inst, attribute.Name, null);
        }
    }
}

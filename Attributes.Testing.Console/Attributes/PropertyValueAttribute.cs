namespace Attributes.Testing.Console.Attributes
{
    public class PropertyValueAttribute : System.Attribute
    {
        public readonly string Name;
        public readonly object Value;

        public PropertyValueAttribute(string name, object val = null)
        {
            Name = name;
            Value = val;
        }
      
    }
}

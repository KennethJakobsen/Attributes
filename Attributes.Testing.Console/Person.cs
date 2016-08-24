using Attributes.Testing.Console.Attributes;

namespace Attributes.Testing.Console
{
    public class Person : ICanBeGenerated
    {
        [PropertyValue("firstName")]
        public string FirstName { get; set; }

        [PropertyValue("lastName")]
        public string LastName { get; set; }

        [PropertyValue("age", 33)]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} år!";
        }
    }

    public interface ICanBeGenerated
    {
    }
}

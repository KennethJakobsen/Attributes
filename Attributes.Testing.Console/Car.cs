using Attributes.Testing.Console.Attributes;

namespace Attributes.Testing.Console
{
    public class Car : ICanBeGenerated
    {
        [PropertyValue("make")]
        public string Make { get; set; }
        [PropertyValue("model")]
        public string Model { get; set; }
        [PropertyValue("flair")]
        public string Flair { get; set; }
        [PropertyValue("year", 1999)]
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model} {Flair}, {Year}";
        }
    }
}

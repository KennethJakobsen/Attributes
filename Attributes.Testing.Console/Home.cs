using Attributes.Testing.Console.Attributes;

namespace Attributes.Testing.Console
{
    public class Home : ICanBeGenerated
    {

        [PropertyValue("address")]
        public string Address { get; set; }
        [PropertyValue("postCode", 1234)]
        public int PostCode { get; set; }
        [PropertyValue("city")]
        public string City { get; set; }
        [PropertyValue("type")]
        public string HomeType { get; set; }

        public override string ToString()
        {
            return $"{HomeType}\r\n{Address}\r\n{PostCode} {City}";
        }
    }
}

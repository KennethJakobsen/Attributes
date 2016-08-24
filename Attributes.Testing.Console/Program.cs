using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Testing.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var ksj = new Dictionary<string, object>
            {
                {"firstName", "Kenneth Snedevind"},
                {"lastName", "Jakobsen"},
                {"age", 33}
            };
            var ks = new Dictionary<string, object>
            {
                {"firstName", "Katrine"},
                {"lastName", "Sørensen"},
                {"age", 30}
            };
            var tkj = new Dictionary<string, object>
            {
                {"firstName", "Theo Kristian"},
                {"lastName", "Jakobsen"},
                {"age", 2}
            };
            var cit = new Dictionary<string, object>
            {
                {"make", "Citroën"},
                {"model", "C1"},
                {"flair", "Aero"},
                {"year", 2014}
            };
            var seat = new Dictionary<string, object>
            {
                {"make", "Seat"},
                {"model", "Ibiza"},
                {"flair", "SW"},
                {"year", 2016}
            };
            var house = new Dictionary<string, object>
            {
                {"address", "Dalsvænget 5"},
                {"postCode", 5550},
                {"city", "Langeskov"},
                {"type", "House"}
            };

            System.Console.WriteLine(ObjectRepository.GetObject<Person>(ksj));
            System.Console.WriteLine(ObjectRepository.GetObject<Person>(ks));
            System.Console.WriteLine(ObjectRepository.GetObject<Person>(tkj));
            System.Console.WriteLine(ObjectRepository.GetObject<Car>(seat));
            System.Console.WriteLine(ObjectRepository.GetObject<Car>(cit));
            System.Console.WriteLine(ObjectRepository.GetObject<Home>(house));
        }
    }
}

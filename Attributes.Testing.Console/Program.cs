using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var swReflect = new Stopwatch();
            swReflect.Start();
            for (var i = 0; i < 100000; i++)
            {
                ObjectRepository.GetObject<Person>(ksj);
                ObjectRepository.GetObject<Person>(ks);
                ObjectRepository.GetObject<Person>(tkj);
                ObjectRepository.GetObject<Car>(seat);
                ObjectRepository.GetObject<Car>(cit);
                ObjectRepository.GetObject<Home>(house);
            }
            swReflect.Stop();
            System.Console.WriteLine(swReflect.Elapsed.ToString());

            var swFactory = new Stopwatch();
            swFactory.Start();
            for (var i = 0; i < 100000; i++)
            {
                ObjectFactory.CreatePerson(ksj["firstName"] as string, ksj["lastName"] as string, Convert.ToInt32(ksj["age"]));
                ObjectFactory.CreatePerson(ks["firstName"] as string, ks["lastName"] as string, Convert.ToInt32(ks["age"]));
                ObjectFactory.CreatePerson(tkj["firstName"] as string, tkj["lastName"] as string, Convert.ToInt32(tkj["age"]));
                ObjectFactory.CreateCar(seat["make"] as string, seat["model"] as string, seat["flair"] as string, Convert.ToInt32(seat["year"]));
                ObjectFactory.CreateCar(cit["make"] as string, cit["model"] as string, cit["flair"] as string, Convert.ToInt32(cit["year"]));
                ObjectFactory.CreateHome(house["address"] as string, house["city"] as string, house["type"] as string, Convert.ToInt32(house["postCode"]));
            }
            swFactory.Stop();
            System.Console.WriteLine(swFactory.Elapsed.ToString());
        }
    }
}

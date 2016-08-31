namespace Attributes.Testing.Console
{
    public class ObjectFactory
    {
        public static Car CreateCar(string make, string model, string flair, int year)
        {
            return new Car()
            {
                Flair = flair,
                Make = make,
                Model = model,
                Year = year
            };
        }
        public static Home CreateHome(string address, string city, string hometype, int post)
        {
            return new Home()
            {
                Address = address,
                City = city,
                HomeType = hometype,
                PostCode = post
            };
        }

        public static Person CreatePerson(string firstname, string lastname,  int age)
        {
            return new Person()
            {
               FirstName = firstname,
               LastName = lastname,
               Age = age
            };
        }
    }
}

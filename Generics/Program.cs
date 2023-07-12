namespace Generics
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} {Surname} {Age}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(("Enter your name: "));
            string Name = Console.ReadLine();
            

            var pr1 = new Person()
            {
                Name = "Fatima",
                Surname = "Qadirova",
                Age = 22,
            };
            var pr2 = new Person()
            {
                Name = "Zahra",
                Surname = "Qadirova",
                Age = 16,
            };
            var pr3 = new Person()
            {
                Name = "Sona",
                Surname = "Mammadova",
                Age= 30,
            };
            var pr4 = new Person()
            {
                Name = "Nurana",
                Surname = "Mammadova",
                Age = 35,
            };
            var pr5 = new Person()
            {
                Name = "Narmin",
                Surname = "Akbarova",
                Age = 18,
            };
            var pr6 = new Person()
            {
                Name = "Gunay",
                Surname = "Amirjanova",
                Age = 28,
            };
            var pr7 = new Person()
            {
                Name = "Leyla",
                Surname = "Xeyrbayova",
                Age = 32,
            };
            var pr8 = new Person()
            {
                Name = "Laman",
                Surname = "Jabraylova",
                Age = 25,
            };
            var pr9 = new Person()
            {
                Name = "Narmin",
                Surname = "Haciyeva",
                Age = 23,
            };
            var pr10 = new Person()
            {
                Name = "Simara",
                Surname = "Azizova",
                Age = 22,
            };

            var list = new List<Person>();

            list.Add(pr1);
            list.Add(pr2);
            list.Add(pr3);
            list.Add(pr4);
            list.Add(pr5);
            list.Add(pr6);
            list.Add(pr7);
            list.Add(pr8);
            list.Add(pr9);
            list.Add(pr10);
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }

    }
}
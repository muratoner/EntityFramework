using System.Linq;
using static System.Console;

namespace SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SqliteContext())
            {
                var people = db.Person.ToList();
                WriteLine($"Initialize People Count: {people.Count}");

                if (!people.Any())
                {
                    100.Create(() => new Person
                    {
                        Id = Faker.RandomNumber.Next(1000),
                        Name = Faker.Name.First(),
                        Surname = Faker.Name.Last()
                    }).ForEach(p => db.Person.Add(p));
                    db.SaveChanges();
                    people = db.Person.ToList();
                }

                WriteLine($"People Count After Add Proccess: {people.Count}");
            }

            ReadLine();
        }
    }
}

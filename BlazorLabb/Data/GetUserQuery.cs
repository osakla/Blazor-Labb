using BlazorLabb.Models;

namespace BlazorLabb.Data
{
    public class GetUserQuery
    {
        public List<Person> Execute()
        {
            return GenerateUsers();
        }

        private  List<Person> GenerateUsers()
        {
            List<Person> persons = new List<Person>
            {
                new Person { Id = 1, Name = "Anna Svensson", Email = "anna.svensson@example.com",
                    Adress = new Adress { Street = "Storgatan 1", ZipCode = "111 22", City = "Stockholm" },
                    Company = new Company { Name = "Teknik AB", CatchPhrase = "Framtidens innovationer" }
                },
                new Person { Id = 2, Name = "Erik Johansson", Email = "erik.johansson@example.com",
                    Adress = new Adress { Street = "Långgatan 23", ZipCode = "223 33", City = "Göteborg" },
                    Company = new Company { Name = "Kreativa Idéer", CatchPhrase = "Design för alla" }
                },
                new Person { Id = 3, Name = "Emma Karlsson", Email = "emma.karlsson@example.com",
                    Adress = new Adress { Street = "Drottninggatan 12", ZipCode = "334 44", City = "Malmö" },
                    Company = new Company { Name = "Ekonomi AB", CatchPhrase = "Din ekonomi i trygga händer" }
                },
                new Person { Id = 4, Name = "Lars Andersson", Email = "lars.andersson@example.com",
                    Adress = new Adress { Street = "Kungsgatan 45", ZipCode = "445 55", City = "Uppsala" },
                    Company = new Company { Name = "Bygg & Co", CatchPhrase = "Hållbart byggande" }
                },
                new Person { Id = 5, Name = "Sara Nilsson", Email = "sara.nilsson@example.com",
                    Adress = new Adress { Street = "Björkvägen 9", ZipCode = "556 66", City = "Västerås" },
                    Company = new Company { Name = "Fastigheter AB", CatchPhrase = "Vi bygger framtiden" }
                },
                new Person { Id = 6, Name = "Oskar Lindgren", Email = "oskar.lindgren@example.com",
                    Adress = new Adress { Street = "Kyrkogatan 8", ZipCode = "667 77", City = "Örebro" },
                    Company = new Company { Name = "IT Solutions", CatchPhrase = "Digitala lösningar för företag" }
                },
                new Person { Id = 7, Name = "Maria Eriksson", Email = "maria.eriksson@example.com",
                    Adress = new Adress { Street = "Södra Vägen 15", ZipCode = "778 88", City = "Linköping" },
                    Company = new Company { Name = "Hälsa & Friskvård", CatchPhrase = "Din hälsa, vår prioritet" }
                },
                new Person { Id = 8, Name = "Johan Persson", Email = "johan.persson@example.com",
                    Adress = new Adress { Street = "Vasagatan 10", ZipCode = "889 99", City = "Helsingborg" },
                    Company = new Company { Name = "Mekaniska AB", CatchPhrase = "Kraft och precision" }
                },
                new Person { Id = 9, Name = "Elin Larsson", Email = "elin.larsson@example.com",
                    Adress = new Adress { Street = "Brunnsgatan 5", ZipCode = "990 00", City = "Jönköping" },
                    Company = new Company { Name = "Mat & Vin", CatchPhrase = "Goda smaker för alla" }
                },
                new Person { Id = 10, Name = "Fredrik Berg", Email = "fredrik.berg@example.com",
                    Adress = new Adress { Street = "Hantverkargatan 3", ZipCode = "101 10", City = "Karlstad" },
                    Company = new Company { Name = "Säkerhet AB", CatchPhrase = "Din trygghet, vårt ansvar" }
                }
            };

            return persons;
        }
    }
}

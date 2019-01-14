using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using src.Models;

namespace src
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* 
                        using (var db = new MyContext())
                        {

                            var person = new Person
                            {
                                Name = "Dinaerte",
                                LastName = "Neto",
                                BirthDate = "1985-07-15",
                                Gender = "M"
                            };

                            person.Adresses = new List<Address>();
                            var address = new Address
                            {
                                Name = "Casa",
                                Type = 1,
                                ZipCode = "09080605",
                                Number = "34",
                                Complement = "Ap 02",
                                StreetName = "Rua Fernão Dias",
                                Neighborhood = "Campestre",
                                City = "Santo André",
                                State = "São Paulo",
                                UF = "SP"
                            };
                            person.Adresses.Add(address);

                            db.People.Add(person);
                            db.SaveChanges();
                        }
                        
                        */

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

using List.Tasks.Models;
using List.Tasks.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List.Tasks.Services.Data
{
    public static class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>()
            {

                new Author()
                {
                    Id = 1,
                    Name="Mark",
                    Surname="Twain",
                    Age=32,
                },
                 new Author()
                {
                    Id = 2,
                    Name="George",
                    Surname="Orwel",
                    Age=45
                },
                  new Author()
                {
                    Id = 3,
                    Name="Jane",
                    Surname="Autsen",
                    Age=64,
                },
                   new Author()
                {
                    Id = 4,
                    Name="Antony",
                    Surname="Mark",
                    Age=29
                },
            };

        }

        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {

                new Employee()
                {
                    Id=1,
                    Surname="Ahmedov",
                    Name="Haci",
                    Salary=1500,
                    Birthday=new DateTime(1995,01,07)


                },
                     new Employee()
                {
                    Id=2,
                    Surname="Nasibli",
                    Name="Tofiq",
                    Salary=3500,
                    Birthday=new DateTime(2004,10,17)


                },
                  new Employee()
                {
                    Id=3,
                    Surname="Aliyeva",
                    Name="Meryem",
                    Salary=4500,
                    Birthday=new DateTime(2000,07,02)


                },
            };
        }


        public static List<User> Users()
        {
            return new List<User>()
            {
                new User()
                {
                    Id=1,
                    UserName="Meryem",
                    Password="meryem12345"

                },
                 new User()
                {
                    Id=2,
                    UserName="Rza",
                    Password="rza12345"

                },
                  new User()
                {
                    Id=3,
                    UserName="Mehemmed",
                    Password="mehemmed12345"

                },
            };
        }

        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id= 1,
                    Name="Iphone",
                    Price=3000
                },
                  new Product()
                {
                    Id= 2,
                    Name="Nokia",
                    Price=300
                },
                    new Product()
                {
                    Id= 3,
                    Name="Samsung",
                    Price=2000
                },
            };
        }

    }
}

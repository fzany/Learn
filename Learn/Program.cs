using Newtonsoft.Json;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //List<User> users = new List<User>() {
            //    new User(){ first_name = "Fermi", gender = Sex.Boy, last_name = "Ade", age = 33 },
            //     new User(){ first_name = "Kingsley", gender = Sex.Boy, last_name = "Phillips", age=10 },
            //      new User(){ first_name = "funke", gender = Sex.Girl, last_name = "ajayi", age=15 },
            //       new User(){ first_name = "Microsoft", gender = Sex.Company, last_name = "Corporation", age=44 },
            //};

            //List<User> tempList = users.Where(dada => dada.gender == Sex.Boy || dada.first_name == "Microsoft").ToList();
            ////r

            //User currentUser = users.FirstOrDefault(f => f.gender == Sex.Boy);

            //double age = users.Average(f => f.age);

            start:
            Logic.Commander();
            goto start;
            //Console.WriteLine();
            Console.ReadKey();
        }


    }
}

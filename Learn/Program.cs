using Newtonsoft.Json;
using Shared;
using System;

namespace Learn
{
    internal class Program
    {
        /// <summary>
        /// Create a list of cars.
        /// </summary>

        private static void Main(string[] args)
        {
            LoadData();
            //int money = StringToIntConverter("50");
            //int moneyInKobo = StringToIntConverter("50", true);
            #region MyRegion
            //List<Car> Cars = new List<Car>()
            //{
            //    new Car(){ Color = "Brown", Insurance =  new Insurance(){ CustomerName = "David"}
            //},
            //    };
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

            //start:
            //Logic.Commander();
            //goto start;
            //Console.WriteLine(); 
            #endregion
            Console.ReadKey();
        }

        private static async void LoadData()
        {
            Staff data = JsonConvert.DeserializeObject<Staff>(await Rester.GetUsers());

        }
        /// <summary>
        /// Calling a Method
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static int StringToIntConverter(string data)
        {
            return int.Parse(data);
        }

        private static int StringToIntConverter(string data, bool iskobo)
        {
            if (iskobo)
            {
                return int.Parse(data) * 100;
            }
            return int.Parse(data);

        }
    }
}

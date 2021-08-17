using Business.Concrete;
using DataAccess.Concrete.EntitiFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var c in result.Data)

                {
                    Console.WriteLine(c.CarName + "/" + c.ColorName + "/" + c.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}


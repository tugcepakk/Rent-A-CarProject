using System;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.BrandName);
                Console.WriteLine(car.ColorName);
                Console.WriteLine(car.DailyPrice);
            }

            //carManager.Add(new Car {BrandId=5, ColorId=3,ModelYear=2020, DailyPrice=0,Description="Dizel", });


        }
	}
}
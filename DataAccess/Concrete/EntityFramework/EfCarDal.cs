using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.RentaCarDbContext;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(RentACarDbContext context =new RentACarDbContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                          
                             select new CarDetailDto
                             {
                                 
                                 BrandName=brand.BrandName,
                                 DailyPrice=car.DailyPrice,
                                 ColorName = color.ColorName

                             };
                return result.ToList();
            }
        }
    }
}

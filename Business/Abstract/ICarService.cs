using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int Id);
        IDataResult<List<Car>> GetByColorId(int ColorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult AddTransactionalTest(Car car);

    }
}

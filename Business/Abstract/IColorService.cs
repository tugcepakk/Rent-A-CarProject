using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

using Entities.Concrete;
namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(Color color );
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll();
    }
}

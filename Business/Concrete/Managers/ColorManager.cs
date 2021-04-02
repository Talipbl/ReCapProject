using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        private IResult BaseProccess(bool state, string message=null)
        {
            if (state)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult();
        }

        public IResult Add(Color color)
        {
            return BaseProccess(_colorDal.Add(color));
        }

        public IResult Delete(Color color)
        {
            return BaseProccess(_colorDal.Delete(color));
        }

        public IResult Update(Color color)
        {
            return BaseProccess(_colorDal.Update(color));
        }
    }
}

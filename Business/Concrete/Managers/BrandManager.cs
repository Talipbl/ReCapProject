using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class BrandManager : IBrandSevice
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        private IResult BaseProccess(bool state, string message)
        {
            if (state)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult();
        }

        public IResult Add(Brand brand)
        {
            return BaseProccess(_brandDal.Add(brand), Messages.Brand.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            return BaseProccess(_brandDal.Delete(brand), Messages.Brand.BrandDeleted);
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.BrandID == 1), Messages.Brand.BrandListed);
        }

        public IDataResult<List<Brand>> GetBrands()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.Brand.BrandsListed);
        }

        public IResult Update(Brand brand)
        {
            return BaseProccess(_brandDal.Update(brand), Messages.Brand.BrandUpdated);
        }
    }
}

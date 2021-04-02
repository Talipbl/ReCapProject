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
    public class CustomerManager : ICustomerService
    {
        IUserDal _customerDal;
        public CustomerManager(IUserDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(User user)
        {
            return new SuccessResult(Messages.Customer.CustomerAdded);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.Customer.CustomerDeleted);
        }

        public IDataResult<User> GetCustomer(int userId)
        {
            return new SuccessDataResult<User>(_customerDal.Get(x => x.UserID == userId), Messages.Customer.CustomerListed);
        }

        public IDataResult<List<User>> GetCustomers()
        {
            return new SuccessDataResult<List<User>>(_customerDal.GetAll(), Messages.Customer.CustomersListed);
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.Customer.CustomerUpdated);
        }
    }
}

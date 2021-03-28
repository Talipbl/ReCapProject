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
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            return new SuccessResult(Messages.Customer.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.Customer.CustomerDeleted);
        }

        public IDataResult<Customer> GetCustomer(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.CustomerID == customerId), Messages.Customer.CustomerListed);
        }

        public IDataResult<List<Customer>> GetCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.Customer.CustomersListed);
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.Customer.CustomerUpdated);
        }
    }
}

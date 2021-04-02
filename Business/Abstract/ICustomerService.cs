using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<User>> GetCustomers();
        IDataResult<User> GetCustomer(int customerId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}

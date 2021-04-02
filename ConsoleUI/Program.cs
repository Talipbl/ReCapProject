using Business.Concrete.Managers;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCustomers();

            //GetRentalWithJoin();

            GetCarsWithJoin();

        }

        private static void GetCarsWithJoin()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsWithJoin().Data)
            {
                Console.WriteLine($"{car.BrandName} {car.CarName} {car.ColorName} {car.DailyPrice}");
            }
        }

        private static void GetRentalWithJoin()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rentals in rentalManager.GetRentals().Data)
            {
                Console.WriteLine($"{rentals.BrandName} {rentals.CarName} {rentals.FirstName} {rentals.LastName} {rentals.RentDate} {rentals.ReturnDate} {rentals.TotalPrice}");
            }
        }

        private static void GetCustomers()
        {
            CustomerManager customerManager = new CustomerManager(new EfUserDal());
            var result = customerManager.GetCustomers().Data;
            foreach (var customer in result)
            {
                //Console.WriteLine($"{customer.User.FirstName} {customer.User.LastName}");
            }
        }
    }
}

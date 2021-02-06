using Business.Concrete;
using DataAccess.Connrete.EntityFremework;
using DataAccess.Connrete.İnMemory;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args) 
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }

        }



















    }
}

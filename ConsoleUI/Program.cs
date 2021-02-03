using Business.Concrete;
using DataAccess.Connrete.İnMemory;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args) 
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Brand + ", " + Environment.NewLine
                    + car.CarId); ;
            }

        }



















    }
}

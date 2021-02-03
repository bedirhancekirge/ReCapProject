using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Connrete.İnMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car { CarId = 1, CategoryId = 2, Brand = "Ford", ModelYear = 2010,Color="Kırmızı", DailyPrice = 100, Description = "Binek Otomobil dizel" },
            new Car { CarId = 2, CategoryId = 2, Brand = "BMW", ModelYear = 2015,Color="Mavi", DailyPrice = 200,Description = "Spor Otomobil benzinlli" },
            new Car { CarId = 3, CategoryId = 2, Brand = "Fiat",ModelYear= 2019,Color="Beyaz", DailyPrice = 400,Description = "Ticari Otomobil benzinli" },
            new Car { CarId = 4, CategoryId = 2, Brand = "Honda",ModelYear = 2009,Color="Gri", DailyPrice = 75,Description = "Binek Otomobil LPG" },
            new Car { CarId = 5, CategoryId = 2, Brand = "Jeep",ModelYear = 1985,Color="Yeşil", DailyPrice = 500,Description = "4x4 Arazi Aracı Benzinli" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCarId(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpbate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpbate.Brand = car.Brand;
            carToUpbate.CategoryId = car.CategoryId;
            carToUpbate.Color = car.Color;
            carToUpbate.CarId = car.CarId;
            carToUpbate.DailyPrice = car.DailyPrice;
            carToUpbate.Description = car.Description;
            carToUpbate.ModelYear = car.ModelYear;
        }

    }
}

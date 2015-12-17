using CarSales.DAL;
using CarSales.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarSales.Repositories
{
    public class CarEntityRepository : ICarRepository
    {
        private CarContext db = new CarContext();

        public List<Car> GetAll() {
            return db.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return db.Cars.Find(id);
        }
    }

}
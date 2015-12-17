using CarSales.Models;
using System.Collections.Generic;

namespace CarSales.Repositories
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        Car GetById(int id);
    }
}

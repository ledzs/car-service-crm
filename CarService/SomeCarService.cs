using System;
using CarService.Models;

namespace CarService
{
    public class SomeCarService : ICarService
    {
        public void AddCar(AddCarModel model)
        {
            Console.WriteLine(model.Brand);
        }
    }
}
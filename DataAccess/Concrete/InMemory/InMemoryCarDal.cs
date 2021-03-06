﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car { Id=1 , BrandId =1 , ColorId = 1 , DailyPrice = 450 , Description="BMW" , ModelYear=2015},
                new Car { Id=2 , BrandId =1 , ColorId = 2 , DailyPrice = 550 , Description="BMW" , ModelYear=2016},
                new Car { Id=3 , BrandId =2 , ColorId = 1 , DailyPrice = 475 , Description="Audi" , ModelYear=2012},
                new Car { Id=4 , BrandId =2 , ColorId = 3 , DailyPrice = 650 , Description="Audi" , ModelYear=2019},
                new Car { Id=5 , BrandId =3 , ColorId = 2 , DailyPrice = 675 , Description="Hyundai" , ModelYear=2020}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _car.SingleOrDefault(c => c.Id == car.Id );
            _car.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}

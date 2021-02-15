using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("---------KİRALIK ARABA LİSTESİ---------\n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine( " Arabanın Modeli : " + car.Description + 
                    "\n Arabanın Üretim Yılı :  " + car.ModelYear + 
                    "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                    "\n Ararabanın Renk Id'si :  " + car.ColorId +
                    "\n Ararabanın Marka Id'si :  " + car.BrandId +
                    "\n----------------------------------------");
            }

        }
    }
}

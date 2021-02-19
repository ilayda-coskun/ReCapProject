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

            //CarData(carManager);
            //CarBrandColorData(carManager);

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(" Arabanın Adı : " + car.CarName +
                    "\n Arabanın Marka Adı :  " + car.BrandName +
                    "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                    "\n Ararabanın Rengi :  " + car.ColorName +
                    "\n----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            


        }

        /*private static void CarData(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(" Arabanın Modeli : " + car.Description +
                    "\n Arabanın Üretim Yılı :  " + car.ModelYear +
                    "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                    "\n Ararabanın Renk Id'si :  " + car.ColorId +
                    "\n Ararabanın Marka Id'si :  " + car.BrandId +
                    "\n----------------------------------------");
            }
        }*/

        /*private static void CarBrandColorData(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(" Arabanın Adı : " + car.CarName +
                    "\n Arabanın Marka Adı :  " + car.BrandName +
                    "\n Ararabanın Günlük Kira Fiyatı :  " + car.DailyPrice +
                    "\n Ararabanın Rengi :  " + car.ColorName +
                    "\n----------------------------------------");
            }
        }*/
    }
}

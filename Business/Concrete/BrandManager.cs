using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2 )
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka ismi eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Marka adı 2 harften küçük olamaz.");
            }
        }

        public void Delete(Brand brand)
        {
            try
            {
                _brandDal.Delete(brand);
                Console.WriteLine("Marka silinmiştir.");
            }
            catch (Exception)
            {
                Console.WriteLine("Böyle bir marka bulunmamaktadır.");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka ismi güncellenmiştir.");
            }
            else
            {
                Console.WriteLine("Marka adı 2 harften küçük olamaz.");
            }
        }
    }
}

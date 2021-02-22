using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join cu in context.Customers on r.CustomerId equals cu.Id
                             select new RentalDetailDto()
                             {
                                 CarName=c.CarName, 
                                 CompanyName = cu.CompanyName, 
                                 DailyPrice=c.DailyPrice, 
                                 Description=c.Description, 
                                 RentDate=r.RentDate, 
                                 ReturnDate=r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}

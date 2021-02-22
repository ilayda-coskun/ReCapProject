using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem kapanmıştır.";

        public static string CarAdded = "Araba eklendi.";
        public static string CarPriceInvalid = "Araba kiralık fiyatı 0'dan büyük olmalıdır . (Araba fiyatı geçersiz)";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDataListed = "Arabalar listelendi ";
        public static string CarDeleted = "Arabalar silinmiştir.";
        public static string CarNotExist = "Böyle bir araba bulunmamaktadır.";

        public static string BrandNameInvalid = "Marka adı en az 2 harften oluşmalıdır. ";
        public static string BrandAdded= "Marka adı eklenmiştir..";
        public static string BrandUpdated = "Markalar ismi güncellenmiştir.";
        public static string BrandDataListed ="Markalar listelendi";
        public static string BrandDeleted = "Marka silinmiştir.";
        public static string BrandNotExist = "Böyle bir marka bulunmamaktadır.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silinmiştir.";
        public static string ColorNotExist = "Böyle bir renk bulunmamaktadır.";
        public static string ColorUpdated = "Renk güncellenmiştir.";
        public static string ColorDataListed = "Renkler listelenmiştir.";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserNotExist = "Böyle bir kullanıcı bulunmamaktadır.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserListed = "Kullanıcılar listelendi.";

        public static string CustomerAdded = "Müşteri ekelendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerNotExist = "Böyle bir Müşteri bulunmamaktadır.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerListed = "Müşteri listelendi.";

        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentalNotAdded = "Kiralama işlemi gerçekleşemedi.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalUpdated = "Kiralama işlemi güncelledi.";

    }
}

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
    }
}

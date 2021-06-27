using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        // public fieldler pascal case olarak yazılır. private olsaydı productAdded.
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürünler güncellendi";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductNameAlreadyExist = "Aynı isimde ürün eklenemez";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak class kalmasın
    public class Product : IEntity //Bu class'a diğer katmanlarda ulaşabilsin diye public yaptık.
                                    //Bir class'ın default erişim belirteci internal'dır. Yani sadece bulunduğun katmandan erişebilirsin.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //Stok adedi. Veritabanında short, smallint olarak tutulur.
        public decimal UnitPrice { get; set; } //Birim fiyatı
    }
}

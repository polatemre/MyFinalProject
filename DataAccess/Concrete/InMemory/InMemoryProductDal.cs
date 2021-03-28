using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişkenler alt çizgiyle verilir.

        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDB...
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak" ,UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera" ,UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon" ,UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye" ,UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare" ,UnitPrice=85, UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product); //Business'dan gelen veriyi veritabanına ekliyoruz.
        }

        public void Delete(Product product)
        {
            ////_products.Remove(product); // bu şekilde istediğimiz product'ı silemeyiz, id üzerinden silmemiz gerekir.

            //Foreach ile çözüm.
            //Product productToDelete = null; //null yazmazsak referansı olmayan Product'ı silmeye çalışmış oluruz.

            //LINQ kullanmadan silmek için
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            //_products.Remove(productToDelete);


            //LINQ - Language Integrated Query ile çözüm.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            // => lambda işareti
            // SingleOrDefault: Tek bir eleman bulmaya yarar.
            // LINQ sorguları yukarıdaki foreach döngüsü gibi döner, p takma ismine her eleman atanır,
            // şart doğru ise o elemanı değişkene atar.

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            // Where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirip onu döndürür.
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

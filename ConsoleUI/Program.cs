﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //sOlid
    //Open Closed Principle: Yeni özellik eklenirken mevcut kodlara dokunmamak.
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            /*foreach (var product in productManager.GetAllByCategoryId(1))
            {
                Console.WriteLine("Product Name: {0}\nCategoryId: {1}\nProductId: {2}\nUnitPrice: {3}\nUnitsInStock: {4}\n", product.ProductName, product.CategoryId, product.ProductId, product.UnitPrice, product.UnitsInStock);
            }
            */

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}

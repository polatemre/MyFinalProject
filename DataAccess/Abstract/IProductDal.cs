using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Interface'in kendisi default olarak public değil fakat methodları publictir.
    //Interface'i public yaparız.
    public interface IProductDal : IEntityRepository<Product>
    {
        //Burada Product için kullanacağımız özel işlemleri yazarız.
        List<ProductDetailDto> GetProductDetails();
    }
}

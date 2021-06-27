using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //dış dünyaya servis etmek istediğimiz şeyler..
        IDataResult<List<Category>> GetAll(); //bütün kategorileri döndür.
        IDataResult<Category> GetById(int categoryId); //tek bir kategori döndür
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;


namespace Entities.Concrete
{
    //Çıplak class kalmasın
    public interface IProductDal
    {
        List<Product> getAll();        
    }
}
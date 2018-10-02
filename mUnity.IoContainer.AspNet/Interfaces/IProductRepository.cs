using mUnity.IoContainer.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mUnity.IoContainer.AspNet.Interfaces
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAll();

        Product Get(int id);

        Product Add(Product item);

        bool Update(Product item);

        bool Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using APW.Data.Models;

namespace APW.Architecture.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}

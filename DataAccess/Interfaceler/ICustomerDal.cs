using Core.GenericRepositoryDesignPattern;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaceler
{
   
    public interface ICustomerDal : IEntityRepository<tb_customer>
    {
    }
}

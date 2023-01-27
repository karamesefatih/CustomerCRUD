using Core.GenericRepositoryDesignPattern;
using DataAccess.EfCore;
using DataAccess.Interfaceler;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Classlar
{
    public class EfCustomerDal : EfEntityRepositoryBase<tb_customer, Context>, ICustomerDal
    {
    }
}

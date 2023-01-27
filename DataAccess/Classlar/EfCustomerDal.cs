using Core;
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
        public string a;
        private readonly Context _context;

        public EfCustomerDal(Context context)
        {
            _context = context;
        }

        public List<tb_customer> GetByCustomerName(string customerName)
        {
            
                       
                var result = _context.tb_customer.Where(f => f.name == customerName).ToList();
                return result;
            
            
        }
    }
}

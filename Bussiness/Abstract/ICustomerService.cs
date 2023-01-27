using Core;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICustomerService
    {
        IDataResult <List<tb_customer>> GetAll();
        IDataResult <List<tb_customer>> GetByCustomerName(string customerName);
        IResult Add_Customer (tb_customer tb_Customer);
        IResult Delete_Customer (tb_customer tb_Customer);
        IResult Update_Customer (tb_customer tb_Customer);
    }
}

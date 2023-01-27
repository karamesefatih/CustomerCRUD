using Bussiness.Abstract;
using Core;
using DataAccess.Interfaceler;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Managers
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add_Customer(tb_customer tb_Customer)
        {
            _customerDal.Add(tb_Customer);
            return new SuccessResult("Ekleme Başarılı"); 
        }

        public IResult Delete_Customer(tb_customer tb_Customer)
        {
            _customerDal.Delete(tb_Customer);
            return new SuccessResult("Silme Başarılı");
        }

        public IDataResult<List<tb_customer>> GetAll()
        {
            return new SuccessDataResult<List<tb_customer>>(_customerDal.GetAll());
            
        }

        public IDataResult<List<tb_customer>> GetByCustomerName(string customerName)
        {
            return new SuccessDataResult<List<tb_customer>>(_customerDal.GetByCustomerName(customerName));
        }

        public IResult Update_Customer(tb_customer tb_Customer)
        {
            _customerDal.Update(tb_Customer);
            return new SuccessResult("Güncelleme Başarılı");
        }
    }
}

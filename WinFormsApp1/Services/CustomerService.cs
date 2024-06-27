using WinFormsApp1.Dto;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services {

    public class CustomerService :ICustomerService {

        private readonly AdventureWorksDW2022Context _dbcontext;

        public CustomerService(AdventureWorksDW2022Context dbcontext) {
        
            _dbcontext = dbcontext;
        }
        public void Test() {

            var customer = _dbcontext.Customers.ToList().FirstOrDefault();

            CustomersDto customersDto = new CustomersDto();
            customersDto.Sid = customer.Sid;
            customersDto.FirstName = customer.FirstName;
            customersDto.LastName = customer.LastName;
            
        }
    }
}

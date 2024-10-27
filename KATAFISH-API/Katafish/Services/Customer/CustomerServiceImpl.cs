using Katafish.Db;
using Katafish.Models;

namespace Katafish.Services
{
    public class CustomerServiceImpl : CustomerService
    {
        private readonly KatafishDbContext context;
        public CustomerServiceImpl(KatafishDbContext context){
            context = context;
        }
        public Customer CreateCustomerAccount(){

        }
    }
}
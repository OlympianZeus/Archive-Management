using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AccessBank.Archive.Customers
{
    public class CustomerAppService:
        CrudAppService<
            Customer,// the customer entity
            CustomerDto,//Used to show customers
            Guid,//PK of the customer entity
            PagedAndSortedResultRequestDto,//used for paging and sorting
            CreateUpdateCustomerDto>,//used to create and update a customer
        ICustomerAppService//Implement the ICustomerAppService
    {
        public CustomerAppService( IRepository<Customer, Guid> repository )
            : base( repository ) 
        {
        
        }
     
    }
}

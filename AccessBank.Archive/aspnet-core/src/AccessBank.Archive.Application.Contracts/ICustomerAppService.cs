using AccessBank.Archive.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AccessBank.Archive
{
    public interface ICustomerAppService:
        ICrudAppService< //Defines CRUD methods
            CustomerDto, // Used to show books
            Guid, // Primary Key
            PagedAndSortedResultRequestDto,//Used for paginf/ Sorting
            CreateUpdateCustomerDto> // Used to create/Update a book
    {

    }
}

using AccessBank.Archive.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AccessBank.Archive
{
    public class ArchiveDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Customer, Guid> _customerRepository;
        public ArchiveDataSeederContributor(IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if( await _customerRepository.GetCountAsync() <= 0)
            {
                await _customerRepository.InsertAsync(
                    new Customer
                    {
                        AccountName = "Test Account",
                        AccountNumber = "30002000000",
                        BranchName ="Test Branch",
                        BranchCode = 200,
                        Category = AccountCategory.Personal,
                        Type = AccountType.Saving,
                        OnBoardDate = new DateTime(2023, 3, 26),
                        AccountStatus = "Active"
                    },
                    autoSave: true
                );

                await _customerRepository.InsertAsync(
                    new Customer
                    {
                        AccountName = "Peter KAHUMUZA",
                        AccountNumber = "30002002024",
                        BranchName = "Goma",
                        BranchCode = 200,
                        Category = AccountCategory.Personal,
                        Type = AccountType.Saving,
                        OnBoardDate = new DateTime(2023, 3, 26),
                        AccountStatus = "Active"
                    },
                    autoSave: true
                );
            }
        }
    }
}

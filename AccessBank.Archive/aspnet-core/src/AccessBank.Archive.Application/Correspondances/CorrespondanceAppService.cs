using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AccessBank.Archive.Correspondances
{
    public class CorrespondanceAppService: 
        CrudAppService<
            Correspondance,
            CorrespondanceDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpadteCorrespondanceDto>,
        ICorrespondanceAppService
    {
        public CorrespondanceAppService(IRepository<Correspondance, Guid> repository)
            :base(repository)
        {
        
        }
    }
}

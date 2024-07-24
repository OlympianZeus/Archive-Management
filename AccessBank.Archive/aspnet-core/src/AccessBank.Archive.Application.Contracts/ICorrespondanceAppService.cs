using AccessBank.Archive.Correspondances;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;


namespace AccessBank.Archive
{
    public interface ICorrespondanceAppService:
   
        ICrudAppService<
            CorrespondanceDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpadteCorrespondanceDto>
    {
    }

   
}

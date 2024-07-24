using AccessBank.Archive.Correspondances;
using AccessBank.Archive.Customers;
using AutoMapper;

namespace AccessBank.Archive;

public class ArchiveApplicationAutoMapperProfile : Profile
{
    public ArchiveApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Customer, CustomerDto>();
        CreateMap<CreateUpdateCustomerDto, Customer>();
        CreateMap<Correspondance, CorrespondanceDto>();
        CreateMap<CreateUpadteCorrespondanceDto, Correspondance>();
    }
}

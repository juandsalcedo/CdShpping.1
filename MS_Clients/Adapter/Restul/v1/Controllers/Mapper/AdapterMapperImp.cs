using MS_Clients.Adapter.Restul.v1.Controllers.Entities;
using MS_Clients.Domain.Entity;

namespace MS_Clients.Adapter.Restul.v1.Controllers.Mapper;

public class AdapterMapperImp : IAdapterMapper
{
    public AdapterClientDto toAdapterClientDto(DomainEntityClient domainEntity)
    {
        return new AdapterClientDto()
        {
            Id = domainEntity.Id,
            FullName = domainEntity.FullName,
            Email = domainEntity.Email,
            Phone = domainEntity.Phone,
            Address = domainEntity.Address,
            RegistrationDate = domainEntity.RegistrationDate,
        };
    }

    public DomainEntityClient toDomainEntityDto(AdapterClientDto adapterClientDto)
    {
        return new DomainEntityClient()
        {
            Id = adapterClientDto.Id,
            FullName = adapterClientDto.FullName,
            Email = adapterClientDto.Email,
            Phone = adapterClientDto.Phone,
            Address = adapterClientDto.Address,
            RegistrationDate = adapterClientDto.RegistrationDate,
        };
    }

    public List<DomainEntityClient> toDomainEntityDtoList(List<AdapterClientDto> adapterClientDtoList)
    {
        if (adapterClientDtoList.Count == 0)
        {
            return new List<DomainEntityClient>();
        }
        else
        {
            return adapterClientDtoList.Select(toDomainEntityDto).ToList();
        }
    }

    public List<AdapterClientDto> toAdapterClientDtoList(List<DomainEntityClient> domainEntityList)
    {
        if (domainEntityList.Count == 0)
        {
            return new List<AdapterClientDto>();
        }
        else
        {
            return domainEntityList.Select(toAdapterClientDto).ToList();
        }
    }
}
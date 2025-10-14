using MS_Clients.Adapter.Restul.v1.Controllers.Entities;
using MS_Clients.Domain.Entity;

namespace MS_Clients.Adapter.Restul.v1.Controllers.Mapper;

public interface IAdapterMapper
{
   AdapterClientDto toAdapterClientDto(DomainEntityClient domainEntity);
   
   DomainEntityClient toDomainEntityDto(AdapterClientDto adapterClientDto);
   
   List<DomainEntityClient> toDomainEntityDtoList(List<AdapterClientDto> adapterClientDtoList);
   
   List<AdapterClientDto> toAdapterClientDtoList(List<DomainEntityClient> domainEntityList);
   
}
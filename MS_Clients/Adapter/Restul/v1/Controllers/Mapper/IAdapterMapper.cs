using MS_Clients.Adapter.Restul.v1.Entities; 
using MS_Clients.Domain.Entity;             
using System.Collections.Generic;         


namespace MS_Clients.Adapter.Restul.v1.Mapper
{
    public interface IAdapterMapper
    {
      
        
        AdapterClientDto ToAdapterClientDto(DomainEntityClient domainEntity);

        List<AdapterClientDto> ToAdapterClientDtoList(List<DomainEntityClient> domainEntityList);
    }
}
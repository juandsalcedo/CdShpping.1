using MS_Clients.Adapter.Restul.v1.Entities;
using MS_Clients.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MS_Clients.Adapter.Restul.v1.Mapper
{
    public class AdapterMapperImp : IAdapterMapper
    {
        // De Dominio (DomainEntityClient), hacia DTO (AdapterClientDto)
        public AdapterClientDto ToAdapterClientDto(DomainEntityClient domainEntity)
        {
            return new AdapterClientDto
            {
                Id = domainEntity.Id,
                Name = domainEntity.Name,
                LastName = domainEntity.LastName,
                Email = domainEntity.Email,
                PhoneNumber = domainEntity.PhoneNumber,
                Address = domainEntity.Address
            };
        }

        public List<AdapterClientDto> ToAdapterClientDtoList(List<DomainEntityClient> domainEntityList)
        {
            return domainEntityList.Select(ToAdapterClientDto).ToList();
        }
    }
}
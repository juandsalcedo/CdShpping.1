using MS_Clients.Domain.Entity;
using MS_Clients.Infraestructure.Entity;

namespace MS_Clients.Infraestructure.Mapper;

public interface IInfraestructureMapper
{
    DomainEntityClient ToDomainClientDto(Client client);
    List<DomainEntityClient> ToDomainClientDtos(List<Client> clients);

    Client toInfraestructureClientDto(DomainEntityClient domainEntity);
    List<Client> toInfraestructureClientDtoList(List<DomainEntityClient> domainEntityList);
    
}
using MS_Clients.Domain.Entity;
using MS_Clients.Infraestructure.Entity;
using System.Collections.Generic; 

namespace MS_Clients.Infraestructure.Mapper
{
    public interface IInfraestructureMapper
    {
        DomainEntityClient ToDomainClientDto(Client client);
        List<DomainEntityClient> ToDomainClientDtos(List<Client> clients);
        Client toInfraestructureClientDto(DomainEntityClient domainEntity);
        
      
    }
}
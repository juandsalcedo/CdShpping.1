using MS_Clients.Domain.Entity;
using MS_Clients.Infraestructure.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MS_Clients.Infraestructure.Mapper
{
    public class InfraestructureMapperImp : IInfraestructureMapper
    {
        //De Base de Datos (Client), hacia Dominio (DomainEntityClient)
        public DomainEntityClient ToDomainClientDto(Client client)
        {
            return new DomainEntityClient
            {
                Id = client.IdUser, 
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                Address = client.Address
               
            };
        }

        // De Dominio DomainEntityClient, hacia Base de Datos (Client)
        public Client toInfraestructureClientDto(DomainEntityClient client)
        {
            return new Client
            {
                IdUser = client.Id, 
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                Address = client.Address
                
            };
        }

        public List<DomainEntityClient> ToDomainClientDtos(List<Client> clients)
        {
            return clients.Select(ToDomainClientDto).ToList();
        }
    }
}
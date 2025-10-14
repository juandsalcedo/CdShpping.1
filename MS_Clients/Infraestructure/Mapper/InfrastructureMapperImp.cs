using MS_Clients.Domain.Entity;
using MS_Clients.Infraestructure.Entity;

namespace MS_Clients.Infraestructure.Mapper;

public class InfrastructureMapperImp : IInfraestructureMapper
{

    public DomainEntityClient ToDomainClientDto(Client client)
    {
        return new  DomainEntityClient()
        {
            Id = client.ClientId,
            FullName = client.ClientFullName,
            Email = client.ClientEmail,
            Phone = client.ClientPhone,
            Address = client.ClientAddress,
            RegistrationDate = client.ClientRegistrationDate
        };
    }

    public List<DomainEntityClient> ToDomainClientDtos(List<Client> clients)
    {
        if (clients.Count == 0)
        {
            return new List<DomainEntityClient>();
        }
        else
        {
            return clients.Select(ToDomainClientDto).ToList();
        }
    }

    public Client toInfraestructureClientDto(DomainEntityClient entity)
    {
        return new Client()
        {
            ClientId = entity.Id,
            ClientFullName = entity.FullName,
            ClientEmail = entity.Email,
            ClientPhone = entity.Phone,
            ClientAddress = entity.Address,
            ClientRegistrationDate = entity.RegistrationDate,
        };
    }

    public List<Client> toInfraestructureClientDtoList(List<DomainEntityClient> domainEntityList)
    {
        if (domainEntityList.Count == 0)
        {
            return new List<Client>();
        }
        else
        {
            return domainEntityList.Select(toInfraestructureClientDto).ToList();
        }
    }
        
}
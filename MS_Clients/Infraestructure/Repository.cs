using Microsoft.EntityFrameworkCore;
using MS_Clients.Application;
using MS_Clients.Domain.Entity; // Necesario para DomainEntityClient
using MS_Clients.Infraestructure.Entity; // Necesario para Client
using MS_Clients.Infraestructure.Mapper;
using System.Collections.Generic; // Necesario para List
using System.Linq; // Necesario para .ToList() y .OrderBy()

namespace MS_Clients.Infraestructure
{
    public class Repository : IClientRepository
    {
        private readonly ClientDbContext _context;
        private readonly IInfraestructureMapper _mapper;

        public Repository(ClientDbContext context, IInfraestructureMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<DomainEntityClient> GetAll()
        {
          
            // Ordenamos por IdUser 
            return _mapper.ToDomainClientDtos(
                _context.Clients.AsNoTracking().OrderBy(client => client.IdUser).ToList()
            );
        }

        public DomainEntityClient GetById(int id)
        {
            // Busca por la Llave Primaria 
            var clientFromDb = _context.Clients.Find(id);

            if (clientFromDb == null)
            {
                return null;
            }
            
            return _mapper.ToDomainClientDto(clientFromDb);
        }

        public void Add(DomainEntityClient client)
        {
            // El mapper ya sabe traducir Id a IdUser
            var clientEntity = _mapper.toInfraestructureClientDto(client);
            _context.Clients.Add(clientEntity);
        }

        public void Delete(int id)
        {
            var clientToDelete = _context.Clients.Find(id);
            if (clientToDelete != null)
            {
                _context.Clients.Remove(clientToDelete);
            }
        }

        
      
        public void Update(DomainEntityClient client)
        {
           
            var clientFromDb = _context.Clients.Find(client.Id);

            if (clientFromDb != null)
            {
               
                clientFromDb.Name = client.Name;
                clientFromDb.LastName = client.LastName;
                clientFromDb.Email = client.Email;
                clientFromDb.PhoneNumber = client.PhoneNumber;
                clientFromDb.Address = client.Address;
            }
        }
    }
}
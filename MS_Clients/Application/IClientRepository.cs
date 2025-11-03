using MS_Clients.Domain.Entity;
using System.Collections.Generic; 

namespace MS_Clients.Application
{
    public interface IClientRepository
    {
        List<DomainEntityClient> GetAll();
        DomainEntityClient GetById(int id);
        void SaveChanges();
        void Add(DomainEntityClient client);
        void Delete(int id);
        void Update(DomainEntityClient client);
    }
}
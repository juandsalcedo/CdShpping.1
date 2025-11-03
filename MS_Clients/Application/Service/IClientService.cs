using MS_Clients.Domain.Entity;
using System.Collections.Generic;

namespace MS_Clients.Application.Service
{
    public interface IClientService
    {
        List<DomainEntityClient> GetAllClients();
        void CreateClient(string name, string lastName, string email, string phoneNumber, string address);
        void UpdateClientName(int id, string name);
        void UpdateClientLastName(int id, string lastName);
        void UpdateClientEmail(int id, string newEmail);
        void UpdateClientPhoneNumber(int id, string newPhone);
        void UpdateClientAddress(int id, string newAddress);
        void DeleteClient(int id);
        
    }
}


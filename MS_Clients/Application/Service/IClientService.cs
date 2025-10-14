using MS_Clients.Domain.Entity;
using System; // Necesario para DateTime
using System.Collections.Generic;

namespace MS_Clients.Application.Service
{
    public interface IClientService
    {
        List<DomainEntityClient> GetAllClients();
        void UpdateClientFullName(int id, string fullName);
        void UpdateClientEmail(int id, string newEmail);
        void UpdateClientPhone(int id, string phone);
        void UpdateClientAddress(int id, string address);
       // void UpdateRegistrationDate(int id, DateTime newRegistrationDate);
    }
}


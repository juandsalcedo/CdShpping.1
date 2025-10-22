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
        
       // void UpdateRegistrationDate(int id, DateTime newRegistrationDate); ARREGLAR ERROR. 
       
       
       //Datos necesarios para crear un cliente -->ClientServiceImp implementacion de logica 
       void CreateClient(string fullName, string email, string phone, string  address);
       
       void DeleteClient(int id);
    }
}


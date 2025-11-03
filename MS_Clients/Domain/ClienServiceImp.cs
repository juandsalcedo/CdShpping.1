using MS_Clients.Application;
using MS_Clients.Application.Service;
using MS_Clients.Domain.Entity;
using System;
using System.Collections.Generic;

namespace MS_Clients.Domain
{
    public class ClientServiceImp : IClientService
    {
        private readonly IClientRepository _repository;

        public ClientServiceImp(IClientRepository repository)
        {
            _repository = repository;
        }

        public List<DomainEntityClient> GetAllClients()
        {
            return _repository.GetAll();
        }
        
        public void CreateClient(string name, string lastName, string email, string phoneNumber, string address)
        {
            var newClient = new DomainEntityClient(name, lastName, email, phoneNumber, address);
            _repository.Add(newClient);
            _repository.SaveChanges();
        }

        public void UpdateClientName(int id, string name)
        {
            var clientToUpdate = _repository.GetById(id);
            if (clientToUpdate != null)
            {
                clientToUpdate.ChangeName(name);
                _repository.Update(clientToUpdate); 
                _repository.SaveChanges();
            }
        }

        public void UpdateClientLastName(int id, string lastName)
        {
            var clientToUpdate = _repository.GetById(id);
            if (clientToUpdate != null)
            {
                clientToUpdate.ChangeLastName(lastName);
                _repository.Update(clientToUpdate);
                _repository.SaveChanges();
            }
        }
        
        public void UpdateClientEmail(int id, string newEmail)
        {
            var clientToUpdate = _repository.GetById(id);
            if (clientToUpdate != null)
            {
                clientToUpdate.ChangeEmail(newEmail);
                _repository.Update(clientToUpdate);
                _repository.SaveChanges();
            }
        }
        
        public void UpdateClientPhoneNumber(int id, string newPhone)
        {
            var clientToUpdate = _repository.GetById(id);
            if (clientToUpdate != null)
            {
                clientToUpdate.ChangePhoneNumber(newPhone);
                _repository.Update(clientToUpdate);
                _repository.SaveChanges();
            }
        }
        
        public void UpdateClientAddress(int id, string newAddress)
        {
            var clientToUpdate = _repository.GetById(id);
            if (clientToUpdate != null)
            {
                clientToUpdate.ChangeAddress(newAddress);
                _repository.Update(clientToUpdate);
                _repository.SaveChanges();
            }
        }
        
        public void DeleteClient(int id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }
    }
}


// C 1.1.0...JDST 


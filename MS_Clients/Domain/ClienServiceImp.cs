using MS_Clients.Application; // Para IClientRepository
using MS_Clients.Application.Service; // Para IClientService
using MS_Clients.Domain.Entity;

namespace MS_Clients.Domain
{
    public class ClientServiceImp : IClientService
    {
        // ARREGLO A: Ahora depende del "contrato" (el enchufe), no de la clase.
        private readonly IClientRepository _repository;

        // ARREGLO B: El constructor ahora pide el "contrato".
        public ClientServiceImp(IClientRepository repository)
        {
            _repository = repository;
        }

        public List<DomainEntityClient> GetAllClients()
        {
            return _repository.GetAll();
        }

        // ARREGLO C: La lógica correcta de la actualización.
        public void UpdateClientFullName(int id, string newFullName)
        {
            // Busca el cliente.
            var clientToUpdate = _repository.GetById(id);

            // Si existe...
            if (clientToUpdate != null)
            {
                // ordena cambiar su nombre.
                clientToUpdate.ChangeFullName(newFullName);

                // guarda los cambios.
                _repository.SaveChanges();
            }
        }
        public void UpdateClientEmail(int id, string newEmail)
        {
            // Busca el cliente usando el repositorio.
            var clientToUpdate = _repository.GetById(id);

            // Si lo encontramos...
            if (clientToUpdate != null)
            {
                // le ordenamos que cambie su email (usando el método del Dominio).
                clientToUpdate.ChangeEmail(newEmail);

                //se guardan los cambios.
                _repository.SaveChanges();
            }
        }

        public void UpdateClientPhone(int id, string phone)
        {
            var clientToUpdate = _repository.GetById(id);

            if (clientToUpdate != null)
            {
                clientToUpdate.ChangePhone(phone);
                _repository.SaveChanges();
            }
        }

        public void UpdateClientAddress(int id, string address)
        {
            var clientToUpdate = _repository.GetById(id);

            if (clientToUpdate != null)
            {
                clientToUpdate.ChangeAddress(address);
                _repository.SaveChanges();
            }
        }
        
        public void UpdateClientRegistrationDate(int id, DateTime newRegistrationDate)
        {
            var clientToUpdate = _repository.GetById(id);

            if (clientToUpdate != null)
            {
                clientToUpdate.ChangeRegistrationDate(newRegistrationDate);
                _repository.SaveChanges();
            }
        }
    }
}


// C 1.1.0...JDST 


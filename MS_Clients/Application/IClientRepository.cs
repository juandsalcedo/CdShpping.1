namespace MS_Clients.Application;
using MS_Clients.Domain.Entity;


public interface IClientRepository
{
    // Contrato: Debe saber cómo traer todos los clientes.
    List<DomainEntityClient> GetAll();

    // Contrato: Debe saber cómo traer un cliente por su ID.
    DomainEntityClient GetById(int id);
        
    // Contrato: Debe saber cómo guardar los cambios.
    void SaveChanges();
}
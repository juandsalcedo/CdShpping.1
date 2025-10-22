using Microsoft.EntityFrameworkCore;
using MS_Clients.Application;
using MS_Clients.Application.Service;
using MS_Clients.Domain.Entity;
using MS_Clients.Infraestructure.Mapper;

namespace MS_Clients.Infraestructure;

public class Repository: IClientRepository
{
    private readonly ClientDbContext _context;
    private readonly IInfraestructureMapper _mapper;

    public Repository(ClientDbContext context,  IInfraestructureMapper mapper)
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
        return _mapper.ToDomainClientDtos(_context.Clients.AsNoTracking().OrderBy(client => client.ClientId).ToList());
    }
    public DomainEntityClient GetById(int id)
    {
        // 1. Busca el cliente en la tabla de la base de datos.
        var clientFromDb = _context.Clients.Find(id);

        // 2. Si no lo encuentra, devuelve nulo.
        if (clientFromDb == null)
        {
            return null;
        }

        // 3. Usa el traductor (mapper) para convertirlo al tipo que la aplicación necesita.
        return _mapper.ToDomainClientDto(clientFromDb);
    }

    public void Add(DomainEntityClient client) 
    {
        //. Traduce del dominio a la infraestructura
        var clientEnity = _mapper.toInfraestructureClientDto(client);
        // Añade al contexto
        _context.Clients.Add(clientEnity);
    }

    public void Delete(int id)
    {
        var clientToDelete = _context.Clients.Find(id);
        if (clientToDelete != null)
        {
            _context.Clients.Remove(clientToDelete);
        }
    }
}
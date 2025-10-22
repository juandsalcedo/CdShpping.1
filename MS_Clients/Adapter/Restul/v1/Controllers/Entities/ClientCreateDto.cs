namespace MS_Clients.Adapter.Restul.v1.Controllers.Entities;

// Formulario para ENVIAR 
public class ClientCreateDto
{
    public string fullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }   
    public string Address { get; set; }
}
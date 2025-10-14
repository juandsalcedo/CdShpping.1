namespace MS_Clients.Adapter.Restul.v1.Controllers.Entities;

public class AdapterClientDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateTime RegistrationDate { get; set; }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace MS_Clients.Infraestructure.Entity;

[Table("Clients")]
public class Client
{
    public int ClientId { get; set; }
    public string ClientFullName { get; set; }
    public string ClientEmail { get; set; }
    public string ClientPhone { get; set; }
    public string ClientAddress { get; set; }
    public DateTime ClientRegistrationDate { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS_Clients.Infraestructure.Entity;


[Table("user")]
public class Client
{
    [Key] //  Llave Primaria
    [Column("IdUser")] 
    public int IdUser { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("lastName")]
    public string LastName { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("phoneNumber")]
    public string PhoneNumber { get; set; }

    [Column("address")]
    public string Address { get; set; }
}
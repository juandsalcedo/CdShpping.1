namespace MS_Clients.Domain.Entity;

public class DomainEntityClient
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }   
    public string Phone { get; set; }
    
    public string Address { get; set; }
    
    public DateTime RegistrationDate { get; set; }

    public void ChangeFullName(string newFullName)
    {
        if (string.IsNullOrWhiteSpace(newFullName))
        {
            //error en caso tal de haber "nombres vacios"
            throw new ArgumentNullException("El nombre completo no puede estar vacío" +
                                            " o contener solo espacios.");
        }
        this.FullName = newFullName;
    }
    public void ChangeEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail))
        {
            throw new ArgumentException("Por favor coloque el Email");
        }

        if (!newEmail.Contains("@"))
        {
            throw new FormatException("Email no valido");
        }
        this.Email = newEmail;
    }

    public void ChangePhone(string newPhone)
    {
        if (string.IsNullOrWhiteSpace(newPhone))
        {
            throw new ArgumentException("Por favor coloque el numero de celular");
        }

        if (!newPhone.All(Char.IsDigit))
        {
            throw new FormatException("Telefono no valido");
        }
        this.Phone = newPhone;
    }

    public void ChangeAddress(string newAddress)
    {
        if (string.IsNullOrWhiteSpace(newAddress))
        {
            throw new ArgumentException("Por favor coloque el nombre");
        }

        if (newAddress.Length < 5)
        {
            throw new ArgumentException("Direccion demasiado corta para ser validada");
        }
        this.Address = newAddress;
    }

    public void ChangeRegistrationDate(DateTime newRegistrationDate)
    {
        if ( newRegistrationDate > DateTime.Now)
        {
            throw new ArgumentException("La fecha de registro no puede estar en el futuro.");
        }
        this.RegistrationDate = newRegistrationDate;
    }
    
}




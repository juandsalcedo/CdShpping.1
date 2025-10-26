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
    
    public DomainEntityClient() {}
    
    // (C) Metodo constructor para crear nuevos clientes
    public DomainEntityClient(string fullName, string email, string phone, string address)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Por favor coloque el nombre completo");
        
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Por favor coloque el email");
        
        if  (string.IsNullOrWhiteSpace(phone))
            throw new ArgumentException("Por favor coloque el telefono");
        
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Por favor coloque su direccion");
        
        this.FullName = fullName;
        this.Email = email;
        this.Phone = phone;
        this.Address = address;
        this.RegistrationDate = DateTime.Now;
        
    }
    
    //Metodos de combinancion

    public string GetFullName()
    {
        return this.FullName;
    }

    public string DeteiledContac()
    {
        return $"Email: {this.Email} - Teléfono: {this.Phone}";
    }
    
    public string ShippingAddress(string city, string country)
    {
        return string.Format("{0}, {1}, {2}", this.Address, city, country);
    }
    
}




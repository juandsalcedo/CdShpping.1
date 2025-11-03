
using System;
using System.Linq;

namespace MS_Clients.Domain.Entity
{
    public class DomainEntityClient
    {
        
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
       
        
        // Constructor vacío (para los Mappers)
        public DomainEntityClient() { }

        // Constructor para crear nuevos clientes
        public DomainEntityClient(string name, string lastName, string email, string phoneNumber, string address)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Por favor coloque el nombre");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Por favor coloque el apellido");
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Email no valido");
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Por favor coloque el telefono");

            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
           
        }

        
        // Metodos de reglas de negocio
        public void ChangeName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentNullException("El nombre no puede estar vacío.");
            }
            this.Name = newName;
        }

        public void ChangeLastName(string newLastName)
        {
            if (string.IsNullOrWhiteSpace(newLastName))
            {
                throw new ArgumentNullException("El apellido no puede estar vacío.");
            }
            this.LastName = newLastName;
        }

        public void ChangeEmail(string newEmail)
        {
            if (string.IsNullOrWhiteSpace(newEmail) || !newEmail.Contains("@"))
            {
                throw new FormatException("Email no valido");
            }
            this.Email = newEmail;
        }

        public void ChangePhoneNumber(string newPhone)
        {
            if (string.IsNullOrWhiteSpace(newPhone))
            {
                throw new ArgumentException("Por favor coloque el numero de celular");
            }
            if (!newPhone.All(char.IsDigit))
            {
                throw new FormatException("Telefono no valido, solo dígitos.");
            }
            this.PhoneNumber = newPhone;
        }

        public void ChangeAddress(string newAddress)
        {
            if (string.IsNullOrWhiteSpace(newAddress))
            {
                throw new ArgumentException("Por favor coloque la dirección");
            }
            if (newAddress.Length < 5)
            {
                throw new ArgumentException("Dirección demasiado corta para ser validada");
            }
            this.Address = newAddress;
        }
        
    }
}




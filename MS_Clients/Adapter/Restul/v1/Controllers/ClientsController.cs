using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using MS_Clients.Adapter.Restul.v1.Controllers.Entities;
using MS_Clients.Application.Service;

namespace MS_Clients.Adapter.Restul.v1.Controllers
{
    [ApiController] 
    [Route("api/v1/clients")] 
    public class ClientsController: ControllerBase
    {
        private readonly IClientService _clientService;
        //llamar al mapper

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public ActionResult<List<AdapterClientDto>> GetAllClients()
        {
            var clients = _clientService.GetAllClients();
            return Ok(clients);
        }
        
        [HttpPatch("{id}/fullname")]
        public IActionResult UpdateFullName(int id, [FromBody] string newFullName)
        {
            try
            {
                _clientService.UpdateClientFullName(id, newFullName);
                return Ok($"El nombre del cliente con ID {id} fue actualizado correctamente.");
            }
            catch (Exception ex)
            {
                // Si el nombre está vacío, devolvemos un error claro.
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPatch("{id}/email")]
        public IActionResult UpdateEmail(int id, [FromBody] string newEmail)
        {
            try
            {
                _clientService.UpdateClientEmail(id, newEmail);
                return Ok($"El email del cliente con ID {id} fue actualizado correctamente.");
            }
            catch (Exception ex)
            {
                // captura cualquier error de las capas inferiores
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}/phone")]
        public IActionResult UpdatePhone(int id, [FromBody] string newPhone)
        {
            try
            {
                _clientService.UpdateClientPhone(id, newPhone);
                return Ok($"El telefono del cliente con ID {id} fue actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}/address")]
        public IActionResult UpdateAddress(int id, [FromBody] string newAddress)
        {
            try
            {
                _clientService.UpdateClientAddress(id, newAddress);
                return Ok($"La direccion del cleinte con ID {id} fue actualizada correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*[HttpPatch("{id}/registrationdate")]
        public IActionResult UpdateRegistrationDate(int id, [FromBody] string newRegistrationDate)
        {
            try
            {
                _clientService.UpdateRegistrationDate(id, newRegistrationDate);
                return Ok($"La fecha de registro del cliente con ID {id} fue actualizada correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
    }
}
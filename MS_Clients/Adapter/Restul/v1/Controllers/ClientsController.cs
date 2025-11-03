using Microsoft.AspNetCore.Mvc;
using MS_Clients.Adapter.Restul.v1.Entities;
using MS_Clients.Application.Service;
using System;
using MS_Clients.Adapter.Restul.v1.Mapper;

namespace MS_Clients.Adapter.Restul.v1.Controllers
{
    [ApiController]
    [Route("api/v1/clients")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IAdapterMapper _adapterMapper;

        public ClientsController(IClientService clientService, IAdapterMapper adapterMapper)
        {
            _clientService = clientService;
            _adapterMapper = adapterMapper;
        }

        
        [HttpGet]
        public IActionResult GetAllClients()
        {
            var domainClients = _clientService.GetAllClients();
            var adapterClients = _adapterMapper.ToAdapterClientDtoList(domainClients);
            return Ok(adapterClients);
        }

        
        [HttpPost]
        public IActionResult CreateClient([FromBody] ClientCreateDto clientDto)
        {
            try
            {
                _clientService.CreateClient(
                    clientDto.Name,
                    clientDto.LastName,
                    clientDto.Email,
                    clientDto.PhoneNumber,
                    clientDto.Address
                );
                return Ok("Cliente creado exitosamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // ENDPOINTS DE ACTUALIZACIN

        
        [HttpPatch("{id}/name")]
        public IActionResult UpdateName(int id, [FromBody] string newName)
        {
            try
            {
                _clientService.UpdateClientName(id, newName);
                return Ok($"El nombre del cliente con ID {id} fue actualizado.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

       
        [HttpPatch("{id}/lastname")]
        public IActionResult UpdateLastName(int id, [FromBody] string newLastName)
        {
            try
            {
                _clientService.UpdateClientLastName(id, newLastName);
                return Ok($"El apellido del cliente con ID {id} fue actualizado.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

       
        [HttpPatch("{id}/email")]
        public IActionResult UpdateEmail(int id, [FromBody] string newEmail)
        {
            try
            {
                _clientService.UpdateClientEmail(id, newEmail);
                return Ok($"El email del cliente con ID {id} fue actualizado.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

       
        [HttpPatch("{id}/phonenumber")]
        public IActionResult UpdatePhoneNumber(int id, [FromBody] string newPhone)
        {
            try
            {
                _clientService.UpdateClientPhoneNumber(id, newPhone);
                return Ok($"El teléfono del cliente con ID {id} fue actualizado.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        
        
        [HttpPatch("{id}/address")]
        public IActionResult UpdateAddress(int id, [FromBody] string newAddress)
        {
            try
            {
                _clientService.UpdateClientAddress(id, newAddress);
                return Ok($"La dirección del cliente con ID {id} fue actualizada.");
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        
        
        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            try
            {
                _clientService.DeleteClient(id);
                return Ok($"Cliente con ID {id} ha sido eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
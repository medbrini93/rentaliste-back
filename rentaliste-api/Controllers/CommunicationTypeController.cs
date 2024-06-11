using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rentaliste_api.Models.dto;
using rentaliste_api.Services.Interfaces;



namespace rentaliste_api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/communicationtype")]
    [ApiController]
    public class CommunicationTypeController : ControllerBase
    {

        private readonly ICommunicationTypeService _communicationTypeService;

        public CommunicationTypeController(ICommunicationTypeService communicationTypeService)
        {
            _communicationTypeService = communicationTypeService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var listCommunicationTypes = _communicationTypeService.GetCommunicationTypes();
                return Ok(listCommunicationTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var listCommunicationTypes = _communicationTypeService.GetCommunicationTypes();
                return Ok(listCommunicationTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] CommunicationTypeDto communicationTypeDto)
        {
            try
            {
                var result = _communicationTypeService.AddCommunicationType(communicationTypeDto);
                return result == true ? Ok() : BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _communicationTypeService.DeleteCommunicationType(id);
                return result == true ? Ok() : BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


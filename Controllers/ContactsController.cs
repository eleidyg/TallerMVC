using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proyecto.Models;
using Microsoft.Extensions.Logging;

namespace proyecto.Controllers
{

   

    [ApiController]
    [Route("api/contacts")]
    public class ContactsController : ControllerBase
    {
       
        [HttpPost("save")]
        public IActionResult Post(Contact contact){
            if(ModelState.IsValid){
                //save contact
            }
            return BadRequest(ModelState);
            
        }


        [HttpGet("get/{id}")]
        public IActionResult get(String id){
            Contact defaulContact = new Contact(id,"PEDRO PEREZ","CRA 24#54-21","");

            return Ok(defaulContact);
                   
        }

        

    }
}

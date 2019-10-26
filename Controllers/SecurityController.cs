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
    [Route("api/security")]
    public class SecurityController : ControllerBase
    {
       
        [HttpPost("login")]
        public IActionResult Post(User user){
            if(ModelState.IsValid){
                if(user.username.ToLower().Equals("admin")){
                    return Ok(encode(user.username));
                }
                return Unauthorized("Invalid User");
            }
            return BadRequest(ModelState);
            
        }


        [HttpGet("check/{token}")]
        public IActionResult check(String token){
            String username = decode(token);

            if(username.ToLower().Equals("admin")){
                return Ok(encode("admin"));
            }
            return Unauthorized("Invalid User");            
        }

        private String encode(String value){
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            byte[] bytUserName = System.Text.Encoding.UTF8.GetBytes(value+"|"+milliseconds);
            return Convert.ToBase64String(bytUserName);
        }
        private String decode(String encoded){
            try{
                byte[] data = System.Convert.FromBase64String(encoded);
                return System.Text.ASCIIEncoding.ASCII.GetString(data).Split("|")[0];
            }catch(Exception e){
                Console.WriteLine("Exception source: {0}", e.Source);
                return "";
            }
        }

    }
}

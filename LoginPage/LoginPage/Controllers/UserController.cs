using LoginPage.DBContext;
using LoginPage.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private LoginDBContext db=null;
        public UserController(LoginDBContext _db)
        {
            db = _db;
        }
        // GET: api/<UserController>
        [HttpGet]
        [Route("[action]")]
        public IActionResult Get()
        {
            Output_Data output = new Output_Data();
            try
            {
                var listdata = db.users.ToList();

                if (listdata!=null)
                {
                    string Data =
                        "{Result:" + Newtonsoft.Json.JsonConvert.SerializeObject(listdata) + "}";
                    JToken json = JObject.Parse(Data);
                    db.SaveChanges();
                    output.message = "Data fetched successfully";
                    output.status = 200;
                    output.data = json;
                    return Ok(output);
                }
                else
                {
                    return BadRequest("Bad request"); 
                }

            }
            catch (Exception ex) 
            {
                output.message = ex.InnerException.ToString();
                output.status = 409;
                output.data = "";
                return NotFound(output);
            }

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        [Route("[action]")]
        public IActionResult GetbyId([FromBody] User objuser)
        {
         var data=db.users.ToList<User>().Where((x => (x.Email == objuser.Email && x.Password==objuser.Password)));
            return Ok();
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("[action]")]
        public  IActionResult Post([FromBody] User objuser)
        {
            Output_Data output = new Output_Data();
            try 
            { 
                if(objuser != null) {
                   db.users.Add(objuser);
                   db.SaveChanges();
                   output.message = "Registered successfully";
                   output.status = 200;
                   output.data = "";
                   return Ok(output);
                }
                else
                {
                    output.message = "Something went wrong";
                    return Ok(output);
                }
            }
            catch (Exception ex)
            {
                output.message = ex.InnerException.ToString();
                output.status = 409;
                output.data = "";
                return NotFound(output);
            }
 


        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        [Route("[action]")]
        public IActionResult Put(int id)
        {
            var data = db.users.ToList<User>().Where(x =>x.Id ==id ).SingleOrDefault();
            return Ok();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        [Route("[action]")]
        public IActionResult Delete(int id)
        {
            var data = db.users.ToList<User>().Where(x => x.Id == id).SingleOrDefault();
            if (data != null)
            {
                db.users.Remove(data);
                db.SaveChanges();
            }
            return Ok();
        }
    }
}

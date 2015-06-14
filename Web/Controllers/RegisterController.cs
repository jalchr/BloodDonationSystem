using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Core.Models;
using Infrastructure.Repository;
using Infrastructure.Repository.Imp;
using Web.Models;
using Web.Models.Mappers;
using Web.Models.Mappers.Imp;

namespace Web.Controllers
{
      [EnableCors(origins: "http://Hasan-PC:17967", headers: "*", methods: "*")]
    public class RegisterController : ApiController
    {
        private IRegisterRepository _registerRepository;
        private IRegisterMapper _registerMapper;



        public RegisterController()
        {
            _registerRepository = new RegisterRepository();
            _registerMapper = new RegisterMapper();

        }

        [HttpGet]
        // Get api/default1
        public IEnumerable<Register> Getall()
        {
            Register[] registers = _registerRepository.SelectAllRegisters();
            return registers;
        }

        [HttpGet]

        public IHttpActionResult Getnext(int id)
        {
            var total = 0;
            var register = _registerRepository.Selectpage(id, out total);
            var data = new { register, total };
            return Ok(data);
        }

        [HttpGet]
        // GET api/default1/5
        public IHttpActionResult Getnew(int id)
        {
            Register register = _registerRepository.GetRegister(id);

            if (register == null)
            {
                return NotFound();
            }
            return Ok(register);
        }
        // POST api/default1
        [HttpPost]
        public void RegisterMember([FromBody]RegisterForm user)
        {
            var map = _registerMapper.Map(user);
            _registerRepository.InsertRegister(map);
        }

        public void Deletenews([FromUri] int id)
        {
            _registerRepository.DeleteRegister(id);
        }

        [HttpPut]
        public void Editnew([FromUri] int id, [FromBody] RegisterForm form)
        {
            var map = _registerMapper.Map(id, form);
            _registerRepository.UpdateRegister(map);
        }
    }
}

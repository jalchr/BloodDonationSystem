using System.Web.Http;
using Infrastructure.Repository;
using Infrastructure.Repository.Imp;
using Web.Models;
using Web.Models.Mappers;
using Web.Models.Mappers.Imp;

namespace Web.Controllers
{
    public class LoginController : ApiController
    {
           private ILoginRepository _loginRepository;
        private ILoginMapper _loginMapper;
        public LoginController()
        {
            _loginRepository = new LoginRepository();
            _loginMapper = new LoginMapper();
        }

        // GET: api/Login
        [HttpPost]
        public bool Verif([FromBody] Loginform form)
        {
            var us = _loginMapper.Map(form);
            var res = _loginRepository.Verification(us);
            return res;
        }

        // GET: api/Login/5
        //public Boolean Get([FromBody]Loginform form)
        //{
        //    return true;
        //}

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}

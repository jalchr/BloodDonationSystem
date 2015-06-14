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
    public class BloodRequestController : ApiController
    {
        private BloodRequestRepository _bloodRequestRepository;
        private BloodRequestMapper _bloodRequestMapper;


        public BloodRequestController()
        {
            _bloodRequestRepository = new BloodRequestRepository();
            _bloodRequestMapper = new BloodRequestMapper();
        }

        [HttpGet]
        // Get api/default1
        public IEnumerable<BloodRequest> Getall([FromUri] int id)
        {
            var bloodRequests = _bloodRequestRepository.GetRequestByUserId(id);
            return bloodRequests;
        }
        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Getrequest(int id)
        {
            var n = _bloodRequestRepository.GetBloodRequest(id);
            if (n == null)
            {
                return NotFound();
            }
            return Ok(n);
        }
        [HttpGet]

        public IHttpActionResult Getnext(int id)
        {
            var total = 0;
            var bloodRequest = _bloodRequestRepository.Selectpage(id, out total);
            var data = new { bloodRequest, total };
            return Ok(data);
        }

        [HttpGet]
        // GET api/default1/5
        public IHttpActionResult Getnew(int id)
        {
            BloodRequest bloodRequest = _bloodRequestRepository.GetBloodRequest(id);

            if (bloodRequest == null)
            {
                return NotFound();
            }
            return Ok(bloodRequest);
        }
        [HttpPost]
        public void PostBloodRequest([FromBody]BloodRequestForm request)
        {
            var map = _bloodRequestMapper.Map(request);
             _bloodRequestRepository.InsertBloodRequest(map);
        }

        //[HttpPost]
        //public void RegisterMember(string userData)
        //{
        //    var user = JsonConvert.DeserializeObject<RegisterForm>(userData);
        //    var map = _registerMapper.Map(user);
        //    _registerRepository.InsertRegister(map);
        //}
        //[HttpPost]
        //[ActionName("Deletenews")]


        public void DeleteBloodRequest([FromUri] int id)
        {
            _bloodRequestRepository.DeleteBloodRequest(id);
        }
        // PUT api/default1/5


        [HttpPut]
        public void EditBloodRequest([FromUri] int id, [FromBody] BloodRequestForm form)
        {
            
                        var map = _bloodRequestMapper.Map(id, form);

                        _bloodRequestRepository.UpdateBloodRequest(map);
             
        }
    }
}

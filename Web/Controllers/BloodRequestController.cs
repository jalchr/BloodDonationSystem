using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Models;
using Infrastructure.Repository;
using Infrastructure.Repository.Imp;

namespace Web.Controllers
{
    public class BloodRequestController : ApiController
    {
        private IBloodRequestRepository _bloodRequestRepository;


        public BloodRequestController()
        {
            _bloodRequestRepository = new BloodRequestRepository();
        }

        [HttpGet]
        // Get api/default1
        public IEnumerable<BloodRequest> Getall()
        {
            BloodRequest[] bloodRequests = _bloodRequestRepository.SelectAllBloodRequests();
            return bloodRequests;
        }

        [HttpGet]

        public IHttpActionResult Getnext(int id)
        {
            var total = 0;
            var bloodRequest = _bloodRequestRepository.Selectpage(id, out total);
            var data = new {bloodRequest, total};
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
    }
}

using System.Web.Http;
using Infrastructure.Repository;
using Infrastructure.Repository.Imp;
using Web.Models;
using Web.Models.Mappers;
using Web.Models.Mappers.Imp;

namespace Web.Controllers
{
    public class PushController : ApiController
    {
        private IPushRepository _pushRepository;
        private IPushMapper _pushMapper;
        public PushController()
        {
            _pushRepository = new PushRepository();
            _pushMapper = new PushMapper();
        }

        [HttpPost]
        public void InsertDevice([FromBody] PushForm form)
        {

            var map = _pushMapper.Map(form);
            _pushRepository.InsertDevice(map);

        }

    }
}

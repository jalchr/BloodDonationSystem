using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Core.Models;

namespace Web.Controllers
{

    public class UploaderController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post()
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            HttpResponseMessage result = null;
            var filePath = "";
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    filePath = HttpContext.Current.Server.MapPath("~/Files/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                    filePath = "/Files/" + postedFile.FileName;
                }
                result = Request.CreateResponse(HttpStatusCode.Created, filePath);
                HttpContext.Current.Items["fpath"] = filePath;
                Staticcl.S = filePath;
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return result;
        }
        
    }
}



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NinePoint.Controllers
{
    public class FileUpLoadController : ApiController
    {
        //https://stackoverflow.com/questions/28369529/how-to-set-up-a-web-api-controller-for-multipart-form-data
        [HttpPost]
        [Route("api/FileUploading/UploadFile")]
        public string UploadFile()
        {
            var file = HttpContext.Current.Request.Files.Count > 0 ?
                HttpContext.Current.Request.Files[0] : null;

            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);

                var path = Path.Combine(
                    HttpContext.Current.Server.MapPath("~/Static"),
                    fileName
                );
                file.SaveAs(path);
            }
            return file != null ? "/uploads/" + file.FileName : null;
        }

    }
}

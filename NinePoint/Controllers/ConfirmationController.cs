using Newtonsoft.Json;
using NinePoint.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;


namespace NinePoint.Controllers
{
    public class ConfirmationController : ApiController
    {
        [HttpPost]
        [Route("api/Confirmation")]
        public IHttpActionResult Confirmation([FromBody] Confirmation confirmation)
        {
            WebRequest tRequest;
            //thiết lập FCM send
            tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            tRequest.Method = "POST";
            tRequest.ContentType = "application/json";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", "AIzaSyDgc8LAfzSgDl9W3XApkInoltAByltPjJE"));
            var payload = new
            {
                to = "dxTZQjpyxdQ:APA91bG6LTiBq_q5IlQEtso6TJjpTMhg7N-KtfzqWxH79-iyckzmC1bVfVzDzeScFVqZdpUAruGwkt4zDUgGmunStxMuaDhipOQ5kCvUKX7s4R5P2qDUdGrjLvIEHAM2TErT_ZrljWiu",
                data = new
                {
                    body = confirmation.body,
                    title = confirmation.title
                }
            };
            string postbody = JsonConvert.SerializeObject(payload).ToString();
            Byte[] byteArray = Encoding.UTF8.GetBytes(postbody);
            tRequest.ContentLength = byteArray.Length;
            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();
            dataStream = tResponse.GetResponseStream();
            StreamReader tReader = new StreamReader(dataStream);
            String sResponseFromServer = tReader.ReadToEnd();
            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return Ok();
        }
    }
}

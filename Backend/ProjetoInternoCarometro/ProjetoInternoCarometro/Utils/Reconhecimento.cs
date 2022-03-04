using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjetoInternoCarometro.Utils
{
    public class Reconhecimento
    {

        public static async void MakeRequest(string faceId1, string faceId2)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "{449e3437fdf34999bc9d6c2ecccc8c2b}");

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/verify?" + queryString;

            HttpResponseMessage response;

            // Request body

            var body = ($"faceId1 : { faceId1}  ,  faceId2 : {faceId2}");

        byte[] byteData = Encoding.UTF8.GetBytes("{" + body + "}");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("<application/json>");
                response = await client.PostAsync(uri, content);
            }

        }

    }
}

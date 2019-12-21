using Domain.Args;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using prmToolkit.NotificationPattern;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Services
{
    public class FilmeSvc:Notifiable, IFilmeSvc
    {
        IConfiguration _configuration;
        public FilmeSvc(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public FilmeResponse RetornaFilme(string titulo)
        {
            var url = _configuration["filmes:url"];
            var key = _configuration["filmes:apikey"];
            var urlReq = string.Format("{0}?apikey={1}&t={2}", url, key, titulo);
            var request = WebRequest.Create(urlReq);
            request.Timeout = 1000;
            request.Method = "GET";
            request.ContentType = "application/json";
            string result = string.Empty;
            var objFilme = new FilmeResponse();
            try
            {
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            result = reader.ReadToEnd();
                        }
                        objFilme = JsonConvert.DeserializeObject<FilmeResponse>(result);
                    }
                }
            }
            catch(WebException e)
            {
                AddNotification("FilmeSvc.RetornaFilme", e.Message);
            }
            catch(Exception e)
            {
                AddNotification("FilmeSvc.RetornaFilme", e.Message);

            }
            return objFilme;

        }
    }
}

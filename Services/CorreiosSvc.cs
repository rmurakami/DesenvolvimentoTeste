using Domain.Args;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CorreiosSvc:Notifiable, ICorreiosSvc
    {
        IConfiguration _configuration;
        public CorreiosSvc(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Efetua pesquisa nos correios
        /// </summary>
        /// <param name="cep">código do cep</param>
        /// <returns></returns>
        public CorreioResponse RetornaEndereco(string cep)
        {

            var retorno = new CorreioResponse();
            try
            {
                cep = cep.Replace("-", "");
                var correioSvc = new svcCorreios.AtendeClienteClient().consultaCEPAsync(cep).Result;
                var result = correioSvc.@return;
                retorno.Endereco = result.end;
                retorno.Uf = result.uf;
                retorno.Cidade = result.cidade;
                retorno.Complemento = result.complemento2;
                retorno.Endereco = result.end;
                retorno.Cep = result.cep;
                retorno.Bairro = result.bairro;

            }
            catch (Exception ex)
            {
                AddNotification("CorreiosResponse.RetornaEndereco", ex.Message);
            }

            return retorno;
        }
    }
}

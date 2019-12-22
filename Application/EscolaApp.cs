using Domain.Interfaces.Application;
using Domain.Interfaces.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class EscolaApp : App<IEscolaRepository>, IEscolaApp
    {
        public Escola Carregar(string id)
        {
            var obj = new Escola();
            try
            {
                obj = _svc.Get(m => m.EscolaId == Guid.Parse(id)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                AddNotification("EscolaApp.Listar", ex.Message);
            }
            return obj;
        }

        public IList<Escola> Listar()
        {
            var lista = new List<Escola>();
            try
            {
                lista = _svc.Listar().ToList();
            }
            catch(Exception ex)
            {
                AddNotification("EscolaApp.Listar", ex.Message);
            }
            return lista;
        }
    }
}

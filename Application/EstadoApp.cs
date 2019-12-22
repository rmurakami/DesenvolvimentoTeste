using Domain.Interfaces.Application;
using Domain.Interfaces.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class EstadoApp : App<IEstadoRepository>, IEstadoApp
    {
        public IList<Estado> Listar()
        {
            var lista = new List<Estado>();
            try
            {
                lista = _svc.GetAll().ToList();
            }
            catch (Exception ex)
            {
                AddNotification("EstadoApp.Listar", ex.Message);
            }
            return lista;
        }

        public Estado Carregar(string uf)
        {
            var obj = new Estado();
            try
            {
                obj = _svc.Get(m=>m.Uf==uf).FirstOrDefault();
            }
            catch (Exception ex)
            {
                AddNotification("EstadoApp.Listar", ex.Message);
            }
            return obj;
        }

    }
}

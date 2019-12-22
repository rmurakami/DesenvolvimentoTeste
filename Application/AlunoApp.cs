using Domain.Args;
using Domain.Interfaces.Application;
using Domain.Interfaces.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class AlunoApp : App<IAlunoRepository>, IAlunoApp
    {

        private IEstadoApp _estadoapp;
        public AlunoApp(IEstadoApp estadoapp)
        {
            _estadoapp = estadoapp;
        }
        public Aluno Carregar(string cpf)
        {
            var obj = new Aluno();
            try
            {
                obj = _svc.Carregar(cpf);
            }
            catch (Exception ex)
            {
                AddNotification("AlunoApp.Carregar", ex.Message);
            }
            return obj;
        }
        public List<Aluno> Listar(string escolaId)
        {
            var lista = new List<Aluno>();
            try
            {
                lista = _svc.Listar(escolaId);
            }
            catch (Exception ex)
            {
                AddNotification("AlunoApp.Listar", ex.Message);
            }
            return lista;
        }
        public void Excluir(string alunoId)
        {
            try
            {
                _svc.Delete(m => m.AlunoId.ToString() == alunoId);
                _svc.Commit();
            }
            catch (Exception ex)
            {
                AddNotification("AlunoApp.Excluir", ex.Message);
            }
        }

    
        public void Gravar(AlunoRequest objReq)
        {
            try
            {
                var obj = new Aluno();
                if (string.IsNullOrEmpty(objReq.AlunoId))
                {

                    objReq.AlunoId = Guid.NewGuid().ToString();
                    obj = (Aluno) objReq;
                    obj.Estado = new Estado { Uf = objReq.EstadoId };
                    obj.Escola = new Escola { EscolaId = Guid.Parse(objReq.EscolaId)};
                    _svc.Adicionar(obj);

                }
                else
                {
                    obj = _svc.Get(m => m.AlunoId.ToString() == objReq.AlunoId).FirstOrDefault();
                    obj = (Aluno) objReq;
                    _svc.Update(obj);

                }
                _svc.Commit();
            }
            catch (Exception ex)
            {
                AddNotification("AlunoApp.Alterar", ex.Message);
            }
        }
    }
}

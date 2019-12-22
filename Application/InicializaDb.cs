using Domain.Models;
using Persistence;
using System;
using System.Linq;

namespace Application
{
    public static class InicializaDb
    {
        public static void Inicialize(Contexto contexto)
        {
            contexto.Database.EnsureCreated();
            if (contexto.Estados.Any())
            {
                return;
            }

            var estados = new Estado[]
            {
                new Estado{Uf="AL", Nome="Alagoas"},
                new Estado{Uf="AC", Nome="Acre"},
                new Estado{Uf="AP", Nome="Amapá"},
                new Estado{Uf="AM", Nome="Amazonas"},
                new Estado{Uf="BA", Nome="Bahia"},
                new Estado{Uf="CE", Nome="Ceará"},
                new Estado{Uf="DF", Nome="Distrito Federal"},
                new Estado{Uf="ES", Nome="Espírito Santo"},
                new Estado{Uf="GO", Nome="Goiás"},
                new Estado{Uf="MA", Nome="Maranhão"},
                new Estado{Uf="MT", Nome="Mato Grosso"},
                new Estado{Uf="MS", Nome="Mato Grosso do Sul"},
                new Estado{Uf="MG", Nome="Minas Gerais"},
                new Estado{Uf="PA", Nome="Pará"},
                new Estado{Uf="PB", Nome="Paraíba"},
                new Estado{Uf="PR", Nome="Paraná"},
                new Estado{Uf="PE", Nome="Pernambuco"},
                new Estado{Uf="PI", Nome="Piauí"},
                new Estado{Uf="RJ", Nome="Rio de Janeiro"},
                new Estado{Uf="RN", Nome="Rio Grande do Norte"},
                new Estado{Uf="RO", Nome="Rondônia"},
                new Estado{Uf="RR", Nome="Roraima"},
                new Estado{Uf="SC", Nome="Santa Catarina"},
                new Estado{Uf="SP", Nome="São Paulo"},
                new Estado{Uf="SE", Nome="Sergipe"}

            };

            foreach (var estado in estados)
            {
                contexto.Add(estado);
            }
            contexto.SaveChanges();

            var escolas = new Escola[]
            {
                new Escola{EscolaId=Guid.NewGuid(), NomeEscola = "EE Afrânio de Oliveira", Estado = contexto.Estados.Where(m=>m.Uf=="SP").FirstOrDefault()},
                new Escola{EscolaId=Guid.NewGuid(), NomeEscola = "EE Agenor de Miranda Araújo Neto - Cazuza",Estado = contexto.Estados.Where(m=>m.Uf=="SP").FirstOrDefault()},
                new Escola{EscolaId=Guid.NewGuid(), NomeEscola = "EE Alexandre de Gusmão", Estado = contexto.Estados.Where(m=>m.Uf=="SP").FirstOrDefault()},
                new Escola{EscolaId=Guid.NewGuid(), NomeEscola = "EE Almirante Barroso", Estado = contexto.Estados.Where(m=>m.Uf=="SP").FirstOrDefault()}

            };

            foreach (var escola in escolas)
            {
                contexto.Add(escola);
            }

            contexto.SaveChanges();
        }

    }
}

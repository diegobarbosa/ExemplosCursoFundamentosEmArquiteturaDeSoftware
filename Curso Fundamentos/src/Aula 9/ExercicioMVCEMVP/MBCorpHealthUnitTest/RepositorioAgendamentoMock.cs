using System;
using System.Collections.Generic;
using MBCorpHealth.Dominio;
using MBCorpHealth.Dominio.Contratos.Repositorio;

namespace MBCorpHealthUnitTest
{
    public class RepositorioAgendamentoMock : IRepositorioAgendamento
    {
        public List<Resultado> RetornarResultadosPorCPFDoPaciente(string CPF)
        {
            List<Resultado> resultados = new List<Resultado>();
            resultados.Add(new Resultado(new Medico("Fabio", "123", "crm"), DateTime.Now.AddDays(23), "resultado teste"));
            return resultados;
        }
    }
}
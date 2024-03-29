﻿using SeletorDeFamilias.Servicos;
using SeletorFamilias.WepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeletorDeFamilias.Testes
{
    public class AvaliarDoCriterioPeloMenosTresDependentes
    {
        [Fact]
        public void DeveAdicionar3PontosAFamiliaQueOAtende()
        {
            var responsavel = new ResponsavelFamiliar("Joao", "00000000000", 500);
            var conjuge = new ConjugeFamiliar("Maria", "00000000001", 500);
            var dataDeNascimento = new DateTime(2000, 07, 26);
            var dependentes = new List<DependenteFamiliar>() { new DependenteFamiliar("Jose", "00000000002", dataDeNascimento),
                                                           new DependenteFamiliar("Joaquina", "00000000003", dataDeNascimento),
                                                           new DependenteFamiliar("Joana", "00000000004", dataDeNascimento)};
            var familia = new Familia(responsavel, conjuge, dependentes);
            var criterio = new CriterioPeloMenosTresDependentes();

            criterio.Avaliar(familia);

            Assert.Equal(3, familia.Pontuacao);
        }
    }
}

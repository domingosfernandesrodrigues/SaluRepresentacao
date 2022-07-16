﻿using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Infra.Data.Repositories
{
    public class ManutencaoVeiculoRepository : RepositoryBase<ManutencaoVeiculo>, IManutencaoVeiculoRepository
    {
        public IEnumerable<ManutencaoVeiculo> BuscarPorPlaca(string placa)
        {
            return Db.ManutencaoVeiculo.Where(p => p.Veiculo.Placa == placa);
        }        
    }
}

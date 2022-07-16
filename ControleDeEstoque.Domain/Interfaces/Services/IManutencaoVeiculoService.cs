﻿using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Interfaces.Services
{
    public interface IManutencaoVeiculoService : IServiceBase<ManutencaoVeiculo>
    {
        IEnumerable<ManutencaoVeiculo> BuscarPorPlaca(string placa);
    }
}

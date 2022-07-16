﻿using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Interface
{
    public interface ICargoAppService : IAppServiceBase<Cargo>
    {
        IEnumerable<Cargo> BuscarPorNome(string nome);
    }
}
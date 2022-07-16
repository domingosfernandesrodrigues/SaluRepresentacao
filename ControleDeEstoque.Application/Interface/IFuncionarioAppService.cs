﻿using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Interface
{
    public interface IFuncionarioAppService : IAppServiceBase<Funcionario>
    {
        IEnumerable<Funcionario> BuscarPorNome(string nome);
    }
}

﻿using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Interfaces
{
    public interface IAlimentacaoRepository : IRepositoryBase<Alimentacao>
    {
        IEnumerable<Alimentacao> BuscarPorNome(string nome);
    }
}
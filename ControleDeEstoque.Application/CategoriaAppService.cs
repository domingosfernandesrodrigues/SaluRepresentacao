using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService)
            : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}

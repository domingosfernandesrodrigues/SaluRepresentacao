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
    public class SubCategoriaAppService : AppServiceBase<SubCategoria>, ISubCategoriaAppService
    {
        private readonly ISubCategoriaService _subCategoriaService;
        public SubCategoriaAppService(ISubCategoriaService subCategoriaService)
            : base(subCategoriaService)
        {
            _subCategoriaService = subCategoriaService;
        }
    }
}

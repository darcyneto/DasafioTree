using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores.Services
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor Fornecedores);
        Task Atualizar(Fornecedor Fornecedores);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}

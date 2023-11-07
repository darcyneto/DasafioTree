using FluentValidation;
using DevIO.Business.Core.Validations.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                //RuleFor(f => f.Documento.Length).Equal(ValidacaoDocs.ValidarCpf)
                //    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                RuleFor(f => ValidacaoDocs.ValidarCpf(f.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é inválido");

            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                //RuleFor(f => f.Documento.Length).Equal(ValidacaoDocs.ValidarCnpj)
                //    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                RuleFor(f => ValidacaoDocs.ValidarCnpj(f.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é inválido");
            });
        }
    }
}

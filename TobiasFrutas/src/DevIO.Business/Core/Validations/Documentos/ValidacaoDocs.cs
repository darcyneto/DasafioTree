using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Core.Validations.Documentos
{  
    public class ValidacaoDocs
    {
        public static bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
            {
                return false;
            }

            if (!cpf.All(char.IsDigit))
            {
                return false;
            }          

            return true;
        }

        public static bool ValidarCnpj(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14)
            {
                return false;
            }

            if (!cnpj.All(char.IsDigit))
            {
                return false;
            }         

            return true;
        }
    }

}

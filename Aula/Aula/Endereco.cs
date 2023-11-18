using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        public override string ToString()
        {
            return $"Rua: {Rua}, Número: {Numero}, Complemento: {Complemento}, Bairro: {Bairro}, Cidade: {Cidade}, UF: {UF}, CEP: {CEP}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Periodico : ItemBiblioteca, IEmprestavel
    {
        public string Periodicidade { get; set; }
        public int Numero { get; set; }
        public int Ano { get; set; }

        public Periodico(int identificacao, string titulo, string periodicidade, int numero, int ano) : base(identificacao, titulo)
        {
            Periodicidade = periodicidade;
            Numero = numero;
            Ano = ano;
        }

        public bool Disponivel()
        {
            // Implementação do método Disponivel()
            return Situacao == "Disponível";
        }

        public bool Emprestado()
        {
            // Implementação do método Emprestado()
            return Situacao == "Emprestado";
        }

        public bool Bloqueado()
        {
            // Implementação do método Bloqueado()
            return Situacao == "Bloqueado";
        }

        public bool Atrasado()
        {
            // So colocar o metodo para atrasado
            return Situacao == "Atrasado";
        }

        public override string ToString()
        {
            // So colocar o metodo de return
            return $"Periódico: {Titulo} - Periodicidade: {Periodicidade} - Número: {Numero} - Ano: {Ano}";
        }
    }

}

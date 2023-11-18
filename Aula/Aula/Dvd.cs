using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class DVD : ItemBiblioteca, IEmprestavel
    {
        public string Assunto { get; set; }
        public int Duracao { get; set; }

        public DVD(int identificacao, string titulo, string assunto, int duracao) : base(identificacao, titulo)
        {
            Assunto = assunto;
            Duracao = duracao;
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
            // Implementação do método Atrasado()
            return Situacao == "Atrasado";
        }

        public override string ToString()
        {
            // Implementação do método ToString()
            return $"DVD: {Titulo} - Assunto: {Assunto} - Duração: {Duracao} minutos";
        }
    }
}
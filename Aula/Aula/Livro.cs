using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Livro : ItemBiblioteca, IEmprestavel
    {
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Paginas { get; set; }

        public Livro(int identificacao, string titulo, string autor, string editora, int paginas) : base(identificacao, titulo)
        {
            Autor = autor;
            Editora = editora;
            Paginas = paginas;
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
            return $"Livro: {Titulo} - Autor: {Autor} - Editora: {Editora}";
        }
    }
}

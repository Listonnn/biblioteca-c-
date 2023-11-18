using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{

    public class Usuario : Pessoa
    {
        public ItemBiblioteca ItemEmprestado { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }

        public Usuario(string nome, Endereco endereco, string matricula, string curso) : base(nome, endereco)
        {
            Matricula = matricula;
            Curso = curso;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Endereço: {Endereco}, Matrícula: {Matricula}, Curso: {Curso}";
        }
    }
}

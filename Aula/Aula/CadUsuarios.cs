using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class CadUsuarios
    {
        private List<Usuario> usuarios;

        public CadUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        public void IncluirUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public int Tamanho()
        {
            return usuarios.Count;
        }

        public Usuario ObterUsuario(int posicao)
        {
            if (posicao >= 0 && posicao < usuarios.Count)
            {
                return usuarios[posicao];
            }
            else
            {
                throw new IndexOutOfRangeException("Posição inválida");
            }
        }

        public void ExcluirUsuario(string matricula)
        {
            Usuario usuario = usuarios.Find(u => u.Matricula == matricula);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
            else
            {
                throw new ArgumentException("Usuário não encontrado");
            }
        }
    }
}

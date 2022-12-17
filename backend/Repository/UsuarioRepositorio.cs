using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Interface;
using backend.Model;

namespace backend.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public void AdicionaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void DeletaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Jogo> ObterUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ObterUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
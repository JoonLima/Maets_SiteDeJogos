using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model;

namespace backend.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<IEnumerable<Usuario>> ObterUsuarios();
        Task<Jogo> ObterUsuario(int id);
        void AdicionaUsuario(Usuario usuario);
        void AtualizaUsuario(Usuario usuario);
        void DeletaUsuario(Usuario usuario);

    }
}
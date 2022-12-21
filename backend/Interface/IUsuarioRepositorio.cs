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
        Task<Usuario> ObterUsuario(int id);
        Task<Usuario> AdicionaUsuario(Usuario usuario);
        Task AtualizaUsuario(Usuario usuario);
        Task DeletaUsuario(Usuario usuario);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interface;
using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BancoDeDados _bancoDeDados;

        public UsuarioRepositorio(BancoDeDados bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public async Task<Usuario> AdicionaUsuario(Usuario usuario)
        {
            await _bancoDeDados.AddAsync(usuario);
            await _bancoDeDados.SaveChangesAsync();
            return usuario;
        }

        public async Task AtualizaUsuario(Usuario usuario)
        {
            _bancoDeDados.Update(usuario);
            await _bancoDeDados.SaveChangesAsync();
        }

        public async Task DeletaUsuario(Usuario usuario)
        {
            _bancoDeDados.Remove(usuario);
            await _bancoDeDados.SaveChangesAsync();
        }

        public async Task<Usuario> ObterUsuario(int id)
        {
            return await _bancoDeDados.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Usuario>> ObterUsuarios()
        {
            return await _bancoDeDados.Usuarios.ToListAsync();
        }
    }
}
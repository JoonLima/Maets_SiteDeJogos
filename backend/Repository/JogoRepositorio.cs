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
    public class JogoRepositorio : IJogoRepositorio
    {
        public readonly BancoDeDados _bancoDeDados;

        public JogoRepositorio(BancoDeDados bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public async Task<Jogo> AdicionaJogo(Jogo jogo)
        {
            await _bancoDeDados.AddAsync(jogo);
            await _bancoDeDados.SaveChangesAsync();
            return jogo;
        }

        public async Task AtualizaJogo(Jogo jogo)
        {
            _bancoDeDados.Update(jogo);
            await _bancoDeDados.SaveChangesAsync();
        }

        public async Task DeletaJogo(Jogo jogo)
        {
            _bancoDeDados.Remove(jogo);
            await _bancoDeDados.SaveChangesAsync();
        }

        public async Task<Jogo> ObterJogo(int id)
        {
            return await _bancoDeDados.Jogos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Jogo>> ObterJogos()
        {
            return await _bancoDeDados.Jogos.ToListAsync();
        }
    }
}
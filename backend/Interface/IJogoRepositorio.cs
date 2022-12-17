using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model;

namespace backend.Interface
{
    public interface IJogoRepositorio
    {
        Task<IEnumerable<Jogo>> ObterJogos();
        Task<Jogo> ObterJogo(int id);
        Task<Jogo> AdicionaJogo(Jogo jogo);
        Task AtualizaJogo(Jogo jogo);
        Task DeletaJogo(Jogo jogo);

    }
}
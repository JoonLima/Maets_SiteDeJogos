using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using backend.Interface;
using backend.Model;
using backend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class JogoController : Controller
    {

        private readonly IJogoRepositorio _repositorio;

        public JogoController(IJogoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<IActionResult> ObterJogos()
        {
            var jogos = await _repositorio.ObterJogos();
            return Ok(jogos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterJogo(int id)
        {
            var jogo = await _repositorio.ObterJogo(id);
            return jogo != null ? Ok(jogo) : BadRequest("Não foi possível encontrar o jogo.");
        }

        [HttpPost]
        public async Task<IActionResult> AdicionaJogo(Jogo jogo)
        {
            var jogoParaAdicionar = await _repositorio.AdicionaJogo(jogo);
            return jogoParaAdicionar == null ? BadRequest("Erro ao salvar cadastro.") : Ok("Jogo cadastrado com sucesso.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletaJogo(int id)
        {
            var jogoParaDeletar = await _repositorio.ObterJogo(id);
            if(jogoParaDeletar == null)
            {
                return BadRequest("Jogo não encontrado. Verifique.");
            }

            await _repositorio.DeletaJogo(jogoParaDeletar);
            return Ok($"Jogo {jogoParaDeletar.Nome} deletado com sucesso.");
        }

        // [HttpPut]
        // public async Task<IActionResult> AtualizaJogo(Jogo jogo)
        // {
        //     var jogoParaAtualizar = await _repositorio.ObterJogo(jogo.Id);
        //     if(jogoParaAtualizar == null)
        //     {
        //         return BadRequest("Jogo não encontrado. Verifique.");
        //     }

        //     await _repositorio.AtualizaJogo(jogoParaAtualizar);
        //     return Ok("Cadastro alterado com sucesso.");

        // }
    }
}
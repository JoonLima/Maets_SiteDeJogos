using backend.Interface;
using backend.Model;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [Route("api/jogos")]
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
        public async Task<IActionResult> AdicionaJogo([FromBody]Jogo jogo)
        {
            var jogoParaAdicionar = await _repositorio.AdicionaJogo(jogo);
            return jogoParaAdicionar == null ? BadRequest("Erro ao salvar cadastro.") : Created("", jogoParaAdicionar);
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
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizaJogo([FromBody]Jogo jogo)
        {
            var jogoParaAtualizar = await _repositorio.ObterJogo(jogo.Id);
            if(jogoParaAtualizar == null)
            {
                return BadRequest("Jogo não encontrado. Verifique.");
            }

            jogoParaAtualizar.Nome = jogo.Nome;
            jogoParaAtualizar.Preco = jogo.Preco;
            jogoParaAtualizar.Categoria = jogo.Categoria;
            jogoParaAtualizar.Classificacao = jogo.Classificacao;
            jogoParaAtualizar.Observacao = jogo.Observacao;

            await _repositorio.AtualizaJogo(jogoParaAtualizar);
            return Ok("Cadastro alterado com sucesso.");

        }
    }
}
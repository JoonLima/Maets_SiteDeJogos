using backend.Interface;
using backend.Model;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [Route("api/usuarios")]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;            
        }

        [HttpGet]
        public async Task<IActionResult> ObterUsuarios()
        {
            var usuarios = await _repositorio.ObterUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterUsuario(int id)
        {
            var usuario = await _repositorio.ObterUsuario(id);
            if(usuario == null)
            {
                return BadRequest("Usuário não encontrado.");
            }

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionaUsuario([FromBody]Usuario usuario)
        {
            var usuarioParaAdicionar = await _repositorio.AdicionaUsuario(usuario);
            return usuarioParaAdicionar == null ? BadRequest("Erro ao adicionar usuário.") : 
                Ok("Usuário adicionado com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> AtualizaUsuario(Usuario usuario)
        {
            var usuarioParaAlterar = await _repositorio.ObterUsuario(usuario.Id);
            if(usuarioParaAlterar == null) 
            {
                return BadRequest("Usuário não encontrado.");
            }

            usuarioParaAlterar.Nome = usuario.Nome;
            usuarioParaAlterar.NivelConta = usuario.NivelConta;
            usuarioParaAlterar.Perfil = usuario.Perfil;
            usuarioParaAlterar.Senha = usuario.Senha;

            await _repositorio.AtualizaUsuario(usuarioParaAlterar);
            return Ok("Usuario alterado com sucesso.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletaUsuario(int id)
        {
            var usuarioParaDeletar = await _repositorio.ObterUsuario(id);
            if(usuarioParaDeletar == null)
            {
                return BadRequest("Usuário não encontrado.");
            }

            await _repositorio.DeletaUsuario(usuarioParaDeletar);
            return Ok("Usuário deletado com sucesso.");
        }
        
    }
}
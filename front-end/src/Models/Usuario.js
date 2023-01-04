export default class Usuario{

    constructor(usuario){
        usuario = usuario || {}

        this.id = usuario.id;
        this.nome = usuario.nome;
        this.email = usuario.email;
        this.nivelConta = usuario.nivelConta;
        this.tipoPerfil = usuario.tipoPerfil;
        this.senha = usuario.senha;
    }
}
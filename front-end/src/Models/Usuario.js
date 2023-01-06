export default class Usuario{

    constructor(usuario){
        usuario = usuario || {}

        this.id = usuario.id;
        this.nome = usuario.nome;
        this.email = usuario.email;
        this.nivelConta = usuario.nivelConta;
        this.senha = usuario.senha;
        this.perfil = usuario.perfil;
    }
}
export default class Jogo{

    constructor(jogo){
        jogo = jogo || {};

        this.id = jogo.id;
        this.nome = jogo.nome;
        this.preco = jogo.preco;
        this.categoria = jogo.categoria;
        this.classificacao = jogo.classificacao;
        this.observacao = jogo.observacao;
    }

    modeloValidoParaCadastroEAtualizacao(){
        return !! (this.nome && this.preco && this.categoria && this.classificacao)
    }
}
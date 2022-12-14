 export default class Produto {
    constructor(obj){
        obj = obj || {};
        this.id = obj.id;
        this.nome = obj.nome;
        this.valor = obj.valor || 0;
    }

    modeloValidoParaCadastro(){
        return !!this.nome;
    }

    modeloValidoParaAtualizar(){
        return !!(this.id && this.nome);
    }
 }
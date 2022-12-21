<template>
    <div class="container">

        <div class="row">
            <div class="col-sm-12">
                <h1 class="titulo">{{ modoCadastro ? "Novo" : "Editar"}} jogo</h1>
                <hr/>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-2">
                <div class="form-group">
                    <label for="id">Código</label>
                    <input id="id" v-model="produto.id" type="text" disabled class="form-control">
                </div>
            </div>

            <div class="col-sm-10">
                <div class="form-group">
                    <label for="nome">Nome</label>
                    <input id="nome" v-model="produto.nome" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-3">
                <div class="form-group">
                    <label for="valor">Valor</label>
                    <input id="valor" v-model="produto.valor" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-3">
                <div class="form-group">
                    <label for="genero">Genero</label>
                    <input id="genero" v-model="produto.genero" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-3">
                <div class="form-group">
                    <label for="faixa-etaria">Faixa etária</label>
                    <input id="faixa-etaria" v-model="produto.faixa" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12">
                <div class="form-group">
                    <label for="observacao">Observação</label>
                    <textarea id="observacao" v-model="produto.observacao" type="text" class="form-control" rows="4"></textarea>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                <br>
                <hr >
            </div>

            <div class="col-sm-12">
                <button @click="cancelarAcao" class="btn btn-default" type="button">Cancelar</button>
                <button @click="salvarCadastro" class="btn btn-primary" type="button">Gravar</button>
            </div>
        </div>
    </div>
</template>

<script>
import Produto from '@/models/Produto';
import produtoService from '@/services/produto-service'

export default {
    name: 'JogoView',


    data(){
        return{
            produto: new Produto(),
            modoCadastro: true,
        }
    },


    mounted(){
        let id = this.$route.params.id
        if(!id) return;

        this.modoCadastro = false;
        this.obterProdutoPorId(id)
    },


    methods:{
        
        obterProdutoPorId(id){
            produtoService.obterPorId(id)
            .then(response => {
                this.produto = new Produto(response.data)
            })
            .catch(error => {
                console.log(error)
            })
        },


        cancelarAcao(){
            this.produto = new Produto()
            this.$router.push({name: "cadastro-de-jogos"})
        },

        cadastrarProduto(){
            if(!this.produto.modeloValidoParaCadastro()){
                alert("O nome do produto é obrigatório para o cadastro.")
                return;
            }

            produtoService.cadastrar(this.produto)
            .then( () => {
                alert("Produto cadastrado com sucesso.")
                this.produto = new Produto();
            })
            .catch(error => {
                console.log(error)
            })
        },

        atualizarProduto(){

            if(!this.produto.modeloValidoParaAtualizar()){
                alert("O nome do produto é obrigatório para o cadastro.")
                return;
            }

            produtoService.atualizar(this.produto)
            .then( () => {
                alert("Produto atualizado com sucesso.")
                this.$router.push({name: "cadastro-de-jogos"})
            })
            .catch( error => {
                console.log(error)
            })

        },

        salvarCadastro(){
            (this.modoCadastro) ? this.cadastrarProduto() : this.atualizarProduto();
        }
    }
}
</script>

<style scoped>

.col-sm-3, .col-sm-2, .col-sm-10, .col-sm-12{
    margin-top: 20px;
}

textarea{
    resize: none;
}

.btn-primary{
    background-color: var(--cor-primaria);
    border: 1.4px solid var(--cor-fundo);
}
.btn-primary:hover{
    background-color: var(--cor-secundaria);
}
.btn{
    float: right;
}


</style>
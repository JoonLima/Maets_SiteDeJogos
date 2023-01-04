<template>
    <div class="container">

        <div class="row">
            <div class="col-sm-12">
                <h3 class="titulo">{{ modoCadastro ? "Novo" : "Editar" }}</h3>
                <hr>
            </div>    
        </div>

        <div class="row">

            <div class="col-sm-2">
                <div class="form-group">
                    <label for="id">Código</label>
                    <input id="id" v-model="jogo.id" type="text" disabled class="form-control">
                </div>
            </div>

            <div class="col-sm-10">
                <div class="form-group">
                    <label for="nome">Nome</label>
                    <input id="nome" v-model="jogo.nome" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-3 margin">
                <div class="form-group">
                    <label for="preco">Preço</label>
                    <input id="preco" v-model="jogo.preco" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-3 margin">
                <div class="form-group">
                    <label for="categoria">Categoria</label>
                    <input id="categoria" v-model="jogo.categoria" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-3 margin">
                <div class="form-group">
                    <label for="classificacao">Classificação</label>
                    <input id="classificacao" v-model="jogo.classificacao" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12 margin">
                <div class="form-group">
                    <label for="observacao">Observação</label>
                    <textarea id="observacao" v-model="jogo.observacao" type="text" class="form-control" rows="4"></textarea>
                </div>
            </div>

        </div>

        <div class="row">
            <div class="col-sm-12">
                <br>
                <hr>
            </div>

            <div class="col-sm-12">
                <button @click="cancelarAcao()" class="btn btn-default" type="button">Cancelar</button>
                <button @click="salvarJogo()" class="btn btn-primary" type="button">Gravar</button>
            </div>
        </div>            

    </div>
</template>

<script>
import Jogo from '@/Models/Jogo'
import jogoService from '@/services/jogo-service';

export default {
    name: 'MeuJogo',

    data(){
        return {
            jogo: new Jogo(),
            modoCadastro: true
        }

    },

    mounted(){
        let id = this.$route.params.id;
        if(!id) return;

        this.modoCadastro = false;
        this.obterJogoPorId(id);
    },

    methods:{

        obterJogoPorId(id){
            jogoService.obterPorId(id)
            .then(response => {
                this.jogo = new Jogo(response.data);
            })
            .catch(error => console.log(error));
        },

        cadastrarJogo(){
            if(!this.jogo.modeloValidoParaCadastroEAtualizacao()){
                this.$swal({
                    icon: 'warning',
                    title: 'Preencha os campos obrigatórios.',
                    confirmButtonColor: '#015393',
                    animate: true
                    })
                return;
            }
            jogoService.cadastrar(this.jogo)
            .then(() => {
                this.$swal({
                    icon: 'success',
                    title: 'Jogo cadastrado com sucesso.',
                    showConfirmButton: false,
                    animate: true,
                    timer: 2000
                    })
                this.$router.push({ name: 'pagina-de-jogos' })
            })
            .catch(error => {
                console.log(error)
            })
        },

        atualizarJogo(){
            if(!this.jogo.modeloValidoParaCadastroEAtualizacao()){
                this.$swal({
                    icon: 'warning',
                    title: 'Preencha os campos obrigatórios.',
                    confirmButtonColor: '#015393',
                    animate: true
                    })
                return;
            }

            jogoService.atualizar(this.jogo)
            .then(() => {
                this.$swal({
                    icon: 'success',
                    title: 'Jogo atualizado com sucesso.',
                    showConfirmButton: false,
                    animate: true,
                    timer: 2000
                    })
                this.$router.push({ name: 'pagina-de-jogos' })
            })
            .catch(error => {
                console.log(error)
            })

        },

        salvarJogo(){
            if(this.modoCadastro){
                this.cadastrarJogo();
            }else{
                this.atualizarJogo();
            }
        },

        cancelarAcao(){
            this.jogo = new Jogo();
            this.$router.push({ name: 'pagina-de-jogos' })
        }
    }
}
</script>

<style scoped>

.margin{
    margin-top: 10px;
}

.btn-primary{
    background-color: var(--cor-primaria);
    border: 1.4px solid var(--cor-fundo);
}

.btn-default{
    background-color: rgb(206, 81, 81);
    border: 1.4px solid var(--cor-fundo);
    color: var(--cor-fundo);
}

.btn-primary:hover{
    background-color: var(--cor-secundaria);
}
.btn-default:hover{
    background-color: rgb(194, 133, 133);
}
.btn{
    float: right;
}

</style>
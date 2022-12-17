<template>
    <div class="container">
      
      <div class="row">
        <div class="col-sm-12">
          <h2 class="titulo">Cadastro de jogos</h2>
          <hr>
        </div>
      </div>

      <div class="row sub-container">
        <div class="col-sm-1">
          <BotaoBase :callback="adicionarJogo" value="Adicionar"></BotaoBase>
        </div>
      </div> 
      
      <div class="row">
        <div class="col-sm-12">
          <table class="table">
            <thead>
              <tr>
                <th>Código</th>
                <th>Nome</th>
                <th>Valor</th>
                <th>Genero</th>
                <th>Faixa etaria</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in produtos" :key="item.id">
                <td>{{ item.id }}</td>
                <td>{{ item.nome }}</td>
                <td>{{ item.valor | real }}</td>
                <td>Ação</td>
                <td>18</td>
                <td class="icones-linha">
                  <i @click="editarJogo(item)" class="fas fa-pencil-alt icones-tabela"></i>
                  <i @click="excluirJogo()" class="fas fa-trash-alt icones-tabela"></i>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import BotaoBase from '@/components/botao/BotaoBase.vue';
  import produtoService from '@/services/produto-service';
  import Produto from '@/models/Produto';
  import conversorMonetario from '@/util/conversor-monetário';

  export default {
    name: 'CadastroDeJogos',
    components:{
      BotaoBase
    },
    filters:{
      real(valor){
        return conversorMonetario.aplicarMascaraParaRealComPreFixo(valor);
      }
    },
    data(){
      return {
        produtos: []
      }
    },
    methods:{

      adicionarJogo(){
        this.$router.push({ name:"novo-jogo" })
      },

      editarJogo(jogo){
        this.$router.push({ name:"editar-jogo", params:{id: jogo.id} })
      },

      excluirJogo(){
        if(confirm(`Deseja excluir o jogo ${jogo.id}`))
      },


      obterTodosOsJogos(){
        produtoService.obterTodos()
        .then(response => { 
          this.produtos = response.data.map(p => new Produto(p));
        })
        .catch(error => { console.log(error) })
      }
    },
    beforeMount(){
      this.obterTodosOsJogos();
    }
  }
  </script>

  <style scoped>

  thead{
    background-color: var(--cor-letras);
    color: var(--cor-fundo);
  }

  .icones-tabela{
    margin: 5px;
    cursor: pointer;
    color: var(--cor-primaria);
  }
  
  </style>
  
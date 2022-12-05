<template>
    <div class="container">
      
      <div class="row">
        <div class="col-sm-12 titulo">
          <h2 class="titulo">Cadastro de jogos</h2>
          <hr>
        </div>
      </div>

      <div class="row sub-container">
        <div class="col-sm-2">
          <BotaoBase value="Adicionar"></BotaoBase>
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
                <td>Editar / Excluir</td>
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
      obterTodosOsProdutos(){
        produtoService.obterTodos()
        .then(response => { 
          this.produtos = response.data.map(p => new Produto(p));
        })
        .catch(error => { console.log(error) })
      }
    },
    beforeMount(){
      this.obterTodosOsProdutos();
    }
  }
  </script>

  <style scoped>
  .table{
    background-color: #1f2329;
  }
  .table th, .table td{
    color: #ddd;
  }

  </style>
  
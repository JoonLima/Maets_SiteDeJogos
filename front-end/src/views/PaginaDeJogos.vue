<template>
  <div class="container">

    <div class="row">
      <div class="col-sm-12">
        <h3 class="titulo">
          Cadastro de jogos
        </h3>
        <hr>
    </div>

    <div class="row">
      <div class="col-sm-2">
        <Botao
        value="Adicionar"
        :call-back="adicionarNovoJogo"
        ></Botao>
      </div>
    </div>

    <div class="row">
      <div class="col-sm-12">
        <table class="table table-hover">
          <thead>
            <tr>
              <th>Código</th>
              <th>Nome</th>
              <th>Preço</th>
              <th>Categoria</th>
              <th>Classificação</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="item in jogos" :key="item.id">
              <td>{{ item.id }}</td>
              <td>{{ item.nome }}</td>
              <td>{{ item.preco | real }}</td>
              <td>{{ item.categoria }}</td>
              <td>{{ item.classificacao }}</td>
              <td>
                <i @click="editarJogo(item)" class="fas fa-pencil-alt icones-tabela"></i>
                <i @click="excluirJogo()" class="fas fa-trash-alt icones-tabela"></i>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>

    </div>
  </div>
</template>

<script>
import Botao from '@/components/Botao/Botao.vue';
import jogoService from '@/services/jogo-service.js';
import Jogo from '@/Models/Jogo.js';
import conversorMonetario from '@/util/conversor-monetario.js';

export default {
  name: 'PaginaDeJogos',
  components:{
    Botao
  },

  filters:{

    real(valor){
      return conversorMonetario.aplicarMascaraParaRealComPreFixo(valor);
    }

  },

  data(){
    return{
      jogos: []
    }
  },

  methods:{

    obterTodosOsJogos(){
      jogoService.obterTodos()
      .then(response => {
        this.jogos = response.data.map(j => new Jogo(j));
      })
      .catch(error => {
        console.log(error)
      })
    },

    adicionarNovoJogo(){
      this.$router.push({ name: 'novo-jogo' })
    },

    excluirJogo(){
      alert('Excluir')
    },

    editarJogo(jogo){
      this.$router.push({ name: 'editar-jogo', params: { id: jogo.id } })

    },    
  },

  mounted(){
    this.obterTodosOsJogos();
  }

}

</script>

<style scoped>

.icones-tabela{
    margin: 5px;
    cursor: pointer;
    color: var(--cor-primaria);
}

.icones-tabela:hover{
  color: var(--cor-secundaria);
}

</style>

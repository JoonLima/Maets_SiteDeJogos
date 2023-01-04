<template>
  <div class="container">
    
    <div class="row">
      <div class="col-sm-12">
        <h3 class="titulo">
          Cadastro de usuários
        </h3>
        <hr>
      </div>
    </div>

    <div class="row">
      <div class="col-sm-2">
        <Botao
        value="Adicionar"
        :call-back="adicionarNovoUsuario"
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
              <th>E-mail</th>
              <th>Nível da conta</th>
              <th>Tipo perfil</th>
              <th>Senha</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="item in usuarios" :key="item.id">
              <td>{{ item.id }}</td>
              <td>{{ item.nome }}</td>
              <td>{{ item.email }}</td>
              <td>{{ item.nivelConta }}</td>
              <td>{{ item.tipoPerfil ? 'Admin' : 'Normal' }}</td>
              <td>{{ item.senha }}</td>
              <td>
                <i @click="editarUsuario(item)" class="fas fa-pencil-alt icones-tabela"></i>
                <i @click="excluirUsuario()" class="fas fa-trash-alt icones-tabela"></i>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>


  </div>
</template>

<script>
import Botao from '@/components/Botao/Botao.vue';
import usuarioService from '@/services/usuario-service';
import Usuario from '@/Models/Usuario';

export default {
  name: 'PaginaDeUsuarios',
  components:{
    Botao
  },

  data(){
    return{
      usuarios: []
    }
  },

  methods:{

    obterTodosOsUsuarios(){
      usuarioService.obterTodos()
      .then(resposta => {
        this.usuarios = resposta.data.map(u => new Usuario(u))
      })
      .catch(error => console.log(error))
    },

    adicionarNovoUsuario(){
      this.$router.push({ name: 'novo-usuario' })
    },

    editarUsuario(usuario){
      this.$router.push({ name: 'editar-usuario', params: {id: usuario.id} })
    },

    excluirUsuario(){
      alert('excluir')
    }

  },

  mounted(){
    this.obterTodosOsUsuarios();
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

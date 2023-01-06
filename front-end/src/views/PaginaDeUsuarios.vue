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
              <td>{{ item.nivelConta | verificarNivel }}</td>
              <td>{{ item.perfil == 1 ? 'Admin' : 'Padrão'}}</td>
              <td>{{ item.senha }}</td>
              <td>
                <i @click="editarUsuario(item)" class="fas fa-pencil-alt icones-tabela"></i>
                <i @click="excluirUsuario(item)" class="fas fa-trash-alt icones-tabela"></i>
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
import conversorNivel from '@/util/conversor-nivel-conta'

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

  filters:{

    verificarNivel(nivel){
      return conversorNivel.verificarNivel(nivel);
    }

},

  methods:{

    obterTodosOsUsuarios(){
      usuarioService.obterTodos()
      .then(resposta => {
        let usuarios = resposta.data.map(u => new Usuario(u))

        this.usuarios = usuarios.sort().reverse();
      })
      .catch(error => console.log(error))
    },

    adicionarNovoUsuario(){
      this.$router.push({ name: 'novo-usuario' })
    },

    editarUsuario(usuario){
      this.$router.push({ name: 'editar-usuario', params: {id: usuario.id} })
    },

    excluirUsuario(usuario){
      this.$swal({
        title: 'Deseja excluir o usuário?',
        text: `Código ${usuario.id} - Nome: ${usuario.nome}`,
        icon: 'question',
        showCancelButton: true,
        confirmButtonColor: '#015393',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Sim',
        cancelButtonText: 'Cancelar',
        animate: true
      })
      .then((result) => {
        if (result.isConfirmed) {
            usuarioService.deletar(usuario.id)
            .then(() => {
            let indice = this.usuarios.findIndex(j => j.id == usuario.id);
            this.usuarios.splice(indice, 1)
            this.$swal({
                    icon: 'success',
                    title: 'Usuário excluído com sucesso.',
                    showConfirmButton: false,
                    animate: true,
                    timer: 1500
                    })
          })
          .catch(error => {
            console.log(error)
          })
        }
      })
    },

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

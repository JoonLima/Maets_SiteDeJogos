<template>
  <div class="box-login">
    <div class="logo">
      <h1>Criar conta</h1>
    </div>

    <div class="row">

      <div class="col-sm-12 margin">
          <div class="form-group">
              <label for="nome">Nome completo</label>
              <input id="nome" v-model="usuario.nome" type="text" class="form-control">
          </div>
      </div>
    </div>

    <div class="row">

    <div class="col-sm-12 margin">
        <div class="form-group">
            <label for="nome">E-mail</label>
            <input id="nome" v-model="usuario.email" type="text" class="form-control">
        </div>
    </div>
    </div>

    <div class="row">

    <div class="col-sm-12 margin">
        <div class="form-group">
            <label for="nome">Senha</label>
            <input id="nome" v-model="usuario.senha" type="password" class="form-control">
        </div>
    </div>
    </div>

    <div class="row">

  <div class="col-sm-12 margin">
      <div class="form-group">
          <label for="nome">Repita a senha</label>
          <input id="nome" type="password" class="form-control">
      </div>
  </div>
  </div>


    <Botao value="Criar conta"
    :callBack="cadastrarUsuario"
    ></Botao>
    
  </div>
</template>

<script>
import Botao from '@/components/Botao/Botao'
import usuarioService from '@/services/usuario-service'
// import Usuario from '@/Models/Usuario'


export default {
  name: "LoginView",
  components: {
    Botao
  },

  data(){
    return{
      usuario:{
        nivelConta: '1',
        perfil: '2'
      }
    }
  },
  
  methods:{

    cadastrarUsuario(){
      usuarioService.cadastrar(this.usuario)
      .then(() => {
                this.$swal({
                    icon: 'success',
                    title: 'Usuario cadastrado com sucesso.',
                    showConfirmButton: false,
                    animate: true,
                    timer: 2000
                    })
                this.$router.push({ name: 'pagina-de-usuarios' })
            })
            .catch(error => {
                console.log(error)
            })
    },

    logar(){
      //Criar uma lógica para acesso ao sistema.
      this.$router.push({ name: 'loja' })
    }
  }
};
</script>

<style scoped>
div.box-login {
  padding: 20px;
  width: 500px;
  margin: auto;
  border: 2px solid;
  border-radius: 7px;
  margin-top: 70px;
  background-color: #fff;
  box-shadow: 0 0 0.7em var(--cor-primaria);;
}

.margin{
    margin-top: 10px;
    font-weight: bold;
}

.logo {
  padding: 25px;
  text-align: center;
}

p {
  font-weight: bold;
}

.link{
  color: var(--cor-primaria);
}

.link:hover{
  color: var(--cor-secundaria);
}

.botao-cadastro{
  background-color: darkgray;
}
</style>
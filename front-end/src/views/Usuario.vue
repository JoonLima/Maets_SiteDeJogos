<template>
    <div class="container box-login">

        <div class="row">
            <div class="col-sm-12">
                <h3 class="titulo">{{ modoCadastro ? "Novo" : "Editar"  }}</h3>
                <hr>
            </div>    
        </div>

        <div class="row">

            <div class="col-sm-12">
                <div class="form-group">
                    <label for="nome">Usuário</label>
                    <input id="nome" v-model="usuario.nome" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12 margin">
                <div class="form-group">
                    <label for="preco">E-mail</label>
                    <input id="email" v-model="usuario.email" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12 margin">
                <div class="form-group">
                    <label for="categoria">Senha</label>
                    <input id="senha" v-model="usuario.senha" type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12 margin">
                <label class="form-check-label">
                    <input v-model="usuario.tipoPerfil" type="checkbox" class="form-check-input">
                    Usuario Administrador
                </label>
            </div>

        </div>

        <div class="row">
            <div class="col-sm-12">
                <br>
                <hr>
            </div>

            {{ usuario }}

            <div class="col-sm-12">
                <button @click="cancelarAcao()" class="btn btn-default" type="button">Cancelar</button>
                <button @click="cadastrarUsuario(usuario)" class="btn btn-primary" type="button">Cadastrar</button>
            </div>
        </div>            


    </div>
</template>

<script>
import Usuario from '@/Models/Usuario';
import usuarioService from '@/services/usuario-service';

export default {
    name: 'MeuJogo',

    data(){
        return{
            usuario: new Usuario(),
            modoCadastro: true
        }
    },

    mounted(){
        let id = this.$route.params.id;
        if(!id) return;

        this.modoCadastro = false;
        this.obterUsuarioPorId(id);
    },

    methods:{

        obterUsuarioPorId(id){
            usuarioService.obterPorId(id)
            .then(response => {
                this.usuario = new Usuario(response.data);
            })
            .catch(error => console.log(error));
        },

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

        atualizarUsuario(){
            alert('atualizar')
        },

        cancelarAcao(){
            this.$router.push({ name: 'pagina-de-usuarios' })
        },

        salvarUsuario(){
            if(this.modoCadastro){
                this.cadastrarUsuario();
            }else{
                this.atualizarUsuario();
            }
        },
    }
}
</script>

<style scoped>

.box-login {
  padding: 20px;
  width: 600px;
  margin: auto;
  /* border: 2px solid; */
  border-radius: 7px;
  margin-top: 70px;
  background-color: #fff;
  
}

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
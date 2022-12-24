<template>
    <div class="container box-login">

        <div class="row">
            <div class="col-sm-12">
                <h3 class="titulo">Novo Usuário</h3>
                <hr>
            </div>    
        </div>

        <div class="row">

            <div class="col-sm-12">
                <div class="form-group">
                    <label for="nome">Usuário</label>
                    <input type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12 margin">
                <div class="form-group">
                    <label for="preco">Senha</label>
                    <input type="text" class="form-control">
                </div>
            </div>

            <div class="col-sm-12 margin">
                <div class="form-group">
                    <label for="categoria">Repita a senha</label>
                    <input type="text" class="form-control">
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
                <button class="btn btn-primary" type="button">Gravar</button>
            </div>
        </div>            


    </div>
</template>

<script>
export default {
    name: 'MeuJogo',

    methods:{
        cancelarAcao(){
            this.$router.push({ name: 'pagina-de-usuarios' })
        }
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
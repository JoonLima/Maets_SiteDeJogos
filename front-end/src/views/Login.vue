<template>
  <div class="box-login">
    <div class="logo">
      <h1>LOGIN</h1>
    </div>

    <InputBase label="E-mail" 
    ></InputBase>

    <InputBase label="Senha"
    type="password"
    ></InputBase>

    <Botao value="Iniciar Sessão"
    :callBack="logar"
    ></Botao>

    <p>• Esqueceu a <router-link class="link" to="/">senha?</router-link> </p>
    <p>• Não tem conta? <router-link class="link" to="/cadastro">Criar</router-link> </p>

    
  </div>
</template>

<script>
import Botao from '@/components/Botao/Botao'
import InputBase from "@/components/InputBase/InputBase";


export default {
  name: "LoginView",
  components: {
    InputBase,
    Botao
  },
  
  methods:{
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
  width: 300px;
  margin: auto;
  border: 2px solid;
  border-radius: 7px;
  margin-top: 70px;
  background-color: #fff;
  box-shadow: 0 0 0.7em var(--cor-primaria);;
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
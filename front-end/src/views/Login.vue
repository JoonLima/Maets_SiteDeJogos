<template>
  <div class="box-login">
    <div class="logo">
      <h1>LOGIN</h1>
    </div>

    <InputBase label="Usuário" 
    placeHolder="exemplo@exemplo.com"
    ></InputBase>

    <InputBase label="Senha"
    placeHolder="123456"
    type="password"
    ></InputBase>

    <BotaoBase value="Iniciar Sessão"
    :callback="logar"
    ></BotaoBase>
  </div>
</template>

<script>
import InputBase from "@/components/input/InputBase.vue";
import BotaoBase from "@/components/botao/BotaoBase.vue";

export default {
  name: "LoginView",
  components: {
    InputBase,
    BotaoBase
  },
  data(){

  },
  methods:{
    logar(){
      //Criar uma lógica para acesso ao sistema.
      this.$router.push({path:'/'})
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
</style>
<template>
  <div class="box-login">
    <div class="logo">
      <h1>LOGIN</h1>
    </div>

    <InputBase label="Iniciar sessão com o nome de usuário" 
    placeHolder="exemplo@exemplo.com"
    ></InputBase>

    <InputBase label="Senha"
    placeHolder="123456"
    type="password"
    ></InputBase>

    <BotaoBase value="Iniciar Sessão"
    :callback="disparar"
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
    disparar(){
      alert('Fui clicado!')
    }
  }
};
</script>

<style scoped>
div.box-login {
  padding: 20px;
  width: 450px;
  margin: auto;
  border: 1px solid;
  border-radius: 7px;
  margin-top: 70px;
  background-color: #181a21;
}

.logo {
  padding: 25px;
  text-align: center;
  color: #ddd;
}
</style>
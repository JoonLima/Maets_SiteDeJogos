<template>

  <nav class="nav">

    <div class="logo">
      <a class="navbar-brand" href="/">Maets</a>
    </div>
    

    <div class="menu-opcoes">

      <router-link to="/">Loja</router-link>

      <router-link to="/cadastro-de-jogos">Cadastro de Jogos</router-link>

      <router-link to="/sobre">Sobre</router-link>
        
    </div>

    <div class="login-cadastro">

      <router-link to="/login">
        <button type="button" class="btn btn-outline-dark">Login</button>
      </router-link>

    </div>

  </nav>
  
</template>

<script>
export default {
  name: "MeuMenu"
};
</script>

<style scoped>

.logo{
  font-size: 29px;
  overflow: hidden;
  text-decoration: none;
  padding: 7px 10px;
  font-weight: bold;
  color: var(--cor-fundo);
}

nav {
  display: flex;
  width: 100%;
  background-color: var(--cor-primaria);
}

.menu-opcoes {
  width: fit-content;
  margin: 0;
  display: flex;
  justify-content: center;
  align-items: center;
  float: left;
}

.menu-opcoes a {
  overflow: hidden;
  text-decoration: none;
  padding: 7px 10px;
  color: var(--cor-fundo);
  float: left;
}

.login-cadastro {
  width: fit-content;
  margin-left: auto;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 7px 10px;
  float: right;
}

.nav .login-cadastro a{
  text-decoration: none;
  color: var(--cor-fundo);
}

.btn-outline-dark{
  color: var(--cor-fundo);
  border: 1.4px solid var(--cor-fundo);
}

.menu-opcoes a:hover {
  color: #fff;
  
}

.btn-outline-dark:hover{
  background-color: var(--cor-secundaria);
}
</style>


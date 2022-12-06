<template>

  <nav class="nav">

    <div class="logo">
      <a class="navbar-brand" href="#">Maets</a>
    </div>
    

    <div class="menu-opcoes">

      <router-link to="/loja">Loja</router-link>

      <router-link to="/cadastro-de-jogos">Cadastro de Jogos</router-link>

      <router-link to="/">Sobre</router-link>
        
    </div>

    <div class="login-cadastro">

      <router-link to="/">Login</router-link>

      <router-link to="/cadastro-de-usuario">Cadastro</router-link>

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
  padding: 15px 20px;
  font-weight: bold;
  color: #ddd;
}

nav {
  display: flex;
}

.menu-opcoes {
  display: flex;
  justify-content: center;
  align-items: center;
}

.menu-opcoes a {
  overflow: hidden;
  text-decoration: none;
  padding: 15px 20px;
  color: #ddd;
}

.login-cadastro {
  display: flex;
  justify-content: center;
  align-items: center;
}

.nav .login-cadastro a{
  text-decoration: none;
  padding: 15px 20px;
  color: #ddd;
}

a:last-child {
  
  float: right;

}

.menu-opcoes a:hover {
  color: #fff;
}
</style>


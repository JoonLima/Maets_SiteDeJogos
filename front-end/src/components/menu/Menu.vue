<template>

  <nav class="nav">

    <a class="navbar-brand" href="#">Maets</a>

    <div class="menu-opcoes">

      <router-link to="/loja">Loja</router-link>

      <router-link to="/cadastro-de-jogos">Cadastro de Jogos</router-link>

      <router-link to="/">Sobre</router-link>

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

.navbar-brand{
  font-size: 29px;
  overflow: hidden;
  float: left;
  text-decoration: none;
  padding: 15px 20px;
  font-weight: bold;
  color: #ddd;
}

nav {
  display: flex;
  background-color: #161a20;
}

.menu-opcoes {
  display: flex;
  justify-content: center;
  margin-left: 270px;
  align-items: center;
}

.menu-opcoes a {
  overflow: hidden;
  text-decoration: none;
  padding: 15px 20px;
  font-weight: bold;
  color: #ddd;
}

a:last-child {
  
  float: right;

}

.menu-opcoes a:hover {
  color: #fff;
}
</style>


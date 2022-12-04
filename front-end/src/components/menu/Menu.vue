<template>
  <nav class="nav">
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
  name: "MeuMenu",
};
</script>

<style scoped>
nav {
  background-color: #161a20;
}

.menu-opcoes {
  width: 100%;
}

.menu-opcoes a {
  overflow: hidden;
  float: left;
  text-decoration: none;
  font-weight: bold;
  color: #ddd;
  padding: 15px 17px;
}

a:first-child {
  margin-left: 40px;
}

a:last-child {
  float: right;
  margin-right: 40px;
}

.menu-opcoes a:hover {
  color: #fff;
}
</style>


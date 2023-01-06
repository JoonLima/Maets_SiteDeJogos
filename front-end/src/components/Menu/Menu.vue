<template>
    <div class="nav container">
        <div class="menu-opcoes">
            <router-link to="/loja">Loja</router-link>
            <router-link to="/pagina-de-jogos">Cadastro de jogos</router-link>
            <router-link to="/pagina-de-usuarios">Cadastro de usuários</router-link>
        </div>
        
        <div class="menu-login">
            <router-link to="/login">
                <button type="button" class="btn btn-outline-dark">Login</button>
            </router-link>
        </div>
    </div>
</template>

<script>
export default {
    name: 'MeuMenu'
}
</script>

<style scoped>

.nav {
  display: flex;
  width: 100%;
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

.menu-login {
  width: fit-content;
  margin-left: auto;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 7px 10px;
  float: right;
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
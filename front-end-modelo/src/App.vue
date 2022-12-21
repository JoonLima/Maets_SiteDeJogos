<template>
  <div id="app">
    <!-- <nav>
      <router-link to="/">Home</router-link> |
      <router-link to="/about">About</router-link>
    </nav> -->
    <Menu v-if="this.$router.currentRoute.name != 'login'"></Menu>
    <router-view/>
  </div>
</template>

<script>
import Menu from '@/components/menu/Menu.vue';

export default {  
  components: {
    Menu
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap');

:root{
  --cor-primaria: #015393;
  --cor-secundaria: #0283c4;
  --cor-fundo: #e3ecfe;
  --cor-letras: #a5a4a4;
}

body{
  font-family: 'Roboto', sans-serif;
  /* position: relative;
  height: 100vh;
  width: 100vw;
  background-size: cover; */
}

hr{
  margin: 0;
}

.titulo{
  font-weight: 600;
  /* margin-top: 10px; */
  font-size: 27px;
}


.sub-container{
  margin-top: 15px;
}

</style>

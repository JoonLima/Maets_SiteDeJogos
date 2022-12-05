<template>
  <div id="app">
    <!-- <nav>
      <router-link to="/">Home</router-link> |
      <router-link to="/about">About</router-link>
    </nav> -->
    <Menu></Menu>
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

body{
  font-family: 'Roboto', sans-serif;
  background-image: url('@/image/1657346739_17-animeshka-org-p-tv-presentation-background-foni-17.jpg');
}

.container{
  margin-top: 15px;
}

.titulo{
  color: #ddd;
}

hr{
  margin: 0;
  color: #ddd;
}

.sub-container{
  margin-top: 15px;
}

</style>

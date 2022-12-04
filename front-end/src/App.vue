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

body{
  background-image: url('@/imagens/1657346739_17-animeshka-org-p-tv-presentation-background-foni-17.jpg');
}

</style>

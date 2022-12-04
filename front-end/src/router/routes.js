import Login from '@/views/Login.vue';
import Loja from '@/views/Loja.vue';
import CadastroDeJogos from '@/views/CadastroDeJogos.vue';
import CadastroDeUsuario from '@/views/CadastroDeUsuario.vue';

const routes = [
    {
        path: '/',
        name: 'login',
        component: Login,
        title: 'login',
        meta: {requiredAuth: false}
    },
    {
        path: '/loja',
        name: 'loja',
        component: Loja,
        title: 'loja',
        meta: {requiredAuth: true}
      },
      {
        path: '/cadastro-de-jogos',
        name: 'cadastro-de-jogos',
        component: CadastroDeJogos,
        title: 'cadastro',
        meta: {requiredAuth: true}
      },
      {
        path: '/cadastro-de-usuario',
        name: 'cadastro-de-usuario',
        component: CadastroDeUsuario,
        title: 'cadastro',
        meta: {requiredAuth: false}
      },
    
  ]

  export default routes;
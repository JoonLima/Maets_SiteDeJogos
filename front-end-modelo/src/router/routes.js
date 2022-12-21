import Login from '@/views/Login.vue';
import Loja from '@/views/Loja.vue';
import CadastroDeJogos from '@/views/CadastroDeJogos.vue';
import CadastroDeUsuario from '@/views/CadastroDeUsuario.vue';
import Jogo from '@/views/Jogo.vue';

const routes = [
    {
        path: '/login',
        name: 'login',
        component: Login,
        title: 'login',
        meta: {requiredAuth: false}
    },
    {
        path: '/',
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
        path: '/cadastro-de-jogos/novo',
        name: 'novo-jogo',
        component: Jogo,
        title: 'Novo jogo',
        meta: {requiredAuth: true}
      },
      {
        path: '/cadastro-de-jogos/editar',
        name: 'editar-jogo',
        component: Jogo,
        title: 'Editar jogo',
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
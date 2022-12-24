import PaginaDeJogos from '@/views/PaginaDeJogos'
import CadastroDeUsuarios from '@/views/PaginaDeUsuarios'
import Loja from '@/views/Loja'
import Login from '@/views/Login'
import Jogo from '@/views/Jogo'
import Usuario from '@/views/Usuario'

const routes = [
    {
      path: '/',
      name: 'login',
      component: Login
    },
    {
        path: '/loja',
        name: 'loja',
        component: Loja
    },
    {
        path: '/pagina-de-usuarios',
        name: 'pagina-de-usuarios',
        component: CadastroDeUsuarios
    },
    {
        path: '/pagina-de-jogos',
        name: 'pagina-de-jogos',
        component: PaginaDeJogos
    },
    {
        path: '/pagina-de-jogos/novo',
        name: 'novo-jogo',
        component: Jogo
    },
    {
        path: '/pagina-de-jogos/editar',
        name: 'editar-jogo',
        component: Jogo
    },
    {
        path: '/pagina-de-usuarios/novo',
        name: 'controle-de-usuarios',
        component: Usuario
    },
    
  ]

  export default routes;
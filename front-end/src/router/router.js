import PaginaDeJogos from '@/views/PaginaDeJogos'
import CadastroDeUsuarios from '@/views/PaginaDeUsuarios'
import Loja from '@/views/Loja'
import Login from '@/views/Login'
import Jogo from '@/views/Jogo'
import Usuario from '@/views/Usuario'
import CadastroPadrao from '@/views/CadastroPadrao'

const routes = [
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
        path: '/',
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
        name: 'novo-usuario',
        component: Usuario
    },
    {
        path: '/pagina-de-usuarios/editar',
        name: 'editar-usuario',
        component: Usuario
    },
    {
        path: '/cadastro',
        name: 'cadastro',
        component: CadastroPadrao
    },    
  ]

  export default routes;
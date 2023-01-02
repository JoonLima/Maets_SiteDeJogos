import { http }  from './config';

function obterTodos(){
    return new Promise((resolve, reject) => {
        return http.get('/jogos')
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function obterPorId(id){
    return new Promise((resolve, reject) => {
        return http.get(`/jogos/${id}`)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function cadastrar(jogo){
    return new Promise((resolve, reject) => {
        return http.post(`jogos`, jogo)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function atualizar(jogo){
    return new Promise((resolve, reject) => {
        return http.put(`/jogos/`, jogo)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function deletar(id){
    return new Promise((resolve, reject) => {
        return http.delete(`/jogos/${id}`)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}


export default {
    obterTodos,
    obterPorId,
    cadastrar,
    atualizar,
    deletar
}
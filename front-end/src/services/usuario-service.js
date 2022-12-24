import { http } from './config'

function obterTodos(){
    return new Promise((resolve, reject) => {
        return http.get('/Usuario')
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function obterPorId(id){
    return new Promise((resolve, reject) => {
        return http.get(`/Usuario/${id}`)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function cadastrar(usuario){
    return new Promise((resolve, reject) => {
        return http.post('/Usuario', usuario)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function atualizar(usuario){
    return new Promise((resolve, reject) => {
        return http.put(`/Usuario/${usuario.id}`, usuario)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function deletar(id){
    return new Promise((resolve, reject) => {
        return http.delete(`/Usuario/${id}`)
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
import { http } from './config'

function obterTodos(){
    return new Promise((resolve, reject) => {
        return http.get('/usuarios')
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function obterPorId(id){
    return new Promise((resolve, reject) => {
        return http.get(`/usuarios/${id}`)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function cadastrar(usuario){
    return new Promise((resolve, reject) => {
        return http.post('/usuarios', usuario)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function atualizar(usuario){
    return new Promise((resolve, reject) => {
        return http.put(`/usuarios`, usuario)
        .then(response => resolve(response))
        .catch(error => reject(error))
    })
}

function deletar(id){
    return new Promise((resolve, reject) => {
        return http.delete(`/usuarios/${id}`)
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
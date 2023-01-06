function verificarNivel(nivel){

   if(nivel == 1){
    return 'Bronze'
   }else if(nivel == 2){
    return 'Prata'
   }else if(nivel == 3){
    return 'Ouro'
   }else if(nivel == 4){
    return 'Platina'
   }else if(nivel == 5){
    return 'Diamante'
   }
}

export default {
    verificarNivel
}
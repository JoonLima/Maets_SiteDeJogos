<template>
    <button @click="callback">
        {{value}}
    </button>
</template>

<script>
export default {
    name:'BotaoBase',
    props:{
        value:{type: String, require},
        callback: {type: Function, default: () => {}}
    }
    
}
</script>

<style scoped>

button{
    width: 100%;
    background-image: linear-gradient(to right, #09b9ff , #1b96fe , #2c72ff);
    color: #ddd;
    padding: 10px;
    margin: 15px 0px;
    border: none;
    border-radius: 1px;
    cursor: pointer;
}

button:hover{
    background-color:  #fff;
}

</style>